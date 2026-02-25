namespace LibraryABC
{
    /// <summary>
    /// class jeux 
    /// </summary>
    public class ClassJeux
    {
        private string _nom;

        /// <summary>
        /// constructeur de class jeux avec un nom en parametre
        /// </summary>
        /// <param name="nom"></param>
        public ClassJeux(string nom)
        {
            Nom = nom;
        }


        /// <summary>
        /// asceseur de _nom
        /// </summary>
        public string Nom 
        {
            get => _nom;
            private set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("le nom ne doit pas etre null");
                }
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le nom ne doit pas contenir de whitespace");
                }
                _nom = value;
            }
        }
    }
}
