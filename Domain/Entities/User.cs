namespace Domain.Entities
{
    /// <summary>
    /// Класс пользователя
    /// </summary>
    public class User 
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Национальность пользователя
        /// </summary>
        public string Nationality { get; set; }
        
        /// <summary>
        /// Возраст пользователя
        /// </summary>
        public int Age { get; set; }
        
        /// <summary>
        /// Пол пользователя
        /// </summary>
        public string Sex { get; set; }
        
        /// <summary>
        /// Место рождения пользователя
        /// </summary>
        public string PlaceOfBirth { get; set; }
        
        /// <summary>
        /// Электронная почта пользователя
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Конструктор для инициализации всех полей класса User.
        /// </summary>
        /// <param name="name">Имя пользователя.</param>
        /// <param name="nationality">Национальность пользователя.</param>
        /// <param name="age">Возраст пользователя.</param>
        /// <param name="sex">Пол пользователя.</param>
        /// <param name="placeOfBirth">Место рождения пользователя.</param>
        /// <param name="email">Электронная почта пользователя.</param>
        /// <param name="password">Пароль пользователя.</param>
        public User(string name, string nationality, int age, string sex, string placeOfBirth, string email, string password)
        {
            Name = name;
            Nationality = nationality;
            Age = age;
            Sex = sex;
            PlaceOfBirth = placeOfBirth;
            Email = email;
            Password = password;
        }
    }
}