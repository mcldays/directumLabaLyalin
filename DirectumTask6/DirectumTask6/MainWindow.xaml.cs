namespace DirectumTask6
{
    using System;
    using System.IO;
    using System.IO.Compression;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;

    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();   // Не ошибка: Лучше сделать окошко побольше, либо разрешить resize.
        }

        /// <summary>
        /// The UnpackStreamToTextBox.
        /// </summary>
        /// <param name="fileName">The fileName<see cref="string"/>.</param>
        /// <param name="textBox">The TextBox<see cref="RichTextBox"/>.</param>
        public static void UnpackStreamToTextBox(string fileName, RichTextBox textBox)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                using (GZipStream unpack = new GZipStream(fs, CompressionMode.Decompress))
                using (MemoryStream memory = new MemoryStream())
                {
                    unpack.CopyTo(memory);
                    TextRange document = new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd);
                    document.Load(memory, DataFormats.Rtf);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                throw new LoadFileException(e.Message, e);
            }

            catch (FileNotFoundException e)
            {
                throw new LoadFileException(e.Message, e);
            }
        }

        /// <summary>
        /// The Button_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UnpackStreamToTextBox(@".\q2.rtf.gz", this.TextBox);        // Лучше добавить файл архива в проект и установить в свойствах "Copy if newer", чтобы файл копировался при сборке.
        }
    }
}
