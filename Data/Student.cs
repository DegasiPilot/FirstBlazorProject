namespace FirstBlazorProject.Data
{
    public class Student
    {
        public Student(string? surname, string? name, string? patronymic, int age, int groupNumber, string? departamentName)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Age = age;
            GroupNumber = groupNumber;
            DepartamentName = departamentName;
        }

        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }
        public int Age { get; set; }
        public int GroupNumber { get; set; }
        public string? DepartamentName { get; set; }

        public static async Task<List<Student>> GetStudentList()
        {
            await Task.Delay(1000);
            return new()
            {
                new Student("Нигматов","Тимур","Ленарович",18,322,"ИС"),
                new Student("Шамаев","Баграм","Радикович",19,322,"ИС"),
                new Student("Абдулов","Адель","Рифкатович",17,322,"ИС"),
                new Student("Габдрахманов","Артур","Анварович",18,322,"ИС"),
            };
        }
    }
}
