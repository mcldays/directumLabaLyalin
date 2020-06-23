namespace DirectumTask2
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Shape" />.
    /// </summary>
    public class Shape  // Лучше сделать класс абстрактным.
    {
        /// <summary>
        /// Gets or sets the XCoordinates.
        /// </summary>
        public List<int> XCoordinates { get; set; } // Не очень хорошо хранить координаты отдельну друг от друга. Тем более если их много.
                                                    // Можно сделать свой класс со свойствами X и Y. Либо воспользоваться Point из System.Drawing.
                                                    // +Лучше убрать set. Надо сделать конструкторы в фигурах и обеспечить корректность их создания.

        /// <summary>
        /// Gets or sets the YCoordinates.
        /// </summary>
        public List<int> YCoordinates { get; set; }

        /// <summary>
        /// Gets or sets the Radius.
        /// </summary>
        public int Radius { get; set; } // Радиус относится к RoundedFigures.
    }
}
