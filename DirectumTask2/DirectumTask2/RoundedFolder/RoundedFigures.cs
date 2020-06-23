namespace DirectumTask2
{
    /// <summary>
    /// Defines the <see cref="RoundedFigures" />.
    /// </summary>
    internal class RoundedFigures : Shape // Лучше сделать абстрактным. И будет правильнее назвать в единственном числе(RoundedFigure).
  {
        /// <summary>
        /// Gets or sets the Circumference.
        /// </summary>
        public virtual double Circumference { get; set; } // Мы не можем задавать длину окружности. Она вычисляется. Поэтому лучше убрать set.
                                                          // + Так как тут нет реализации, то лучше сделать свойство абстрактным, а не виртуальным.
    }
}
