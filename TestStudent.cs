using StudentServiceLib;

namespace TestProject2
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void Score8_Should_ReturnA()
        {
            Student s = new Student();

            s.Id = 1;
            s.Name = "Toan";
            s.Age = 18;
            s.Score = 8.0;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void Score7AndHalf_Should_ReturnB()
        {
            Student s = new Student();

            s.Id = 2;
            s.Name = "Thi";
            s.Age = 18;
            s.Score = 7.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void Score7_Should_ReturnB()
        {
            Student s = new Student();

            s.Id = 3;
            s.Name = "Trang";
            s.Age = 18;
            s.Score = 7;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void Score5AndHalf_Should_ReturnC()
        {
            Student s = new Student();

            s.Id = 4;
            s.Name = "Trung";
            s.Age = 18;
            s.Score = 5.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }


        [TestMethod]
        public void addFirstStudent_ShouldSuccess_AndReturnTrue()
        {
            StudentService sv = new StudentService();
            Student s = new Student() { Id = 5, Name = "Tuyet", Age = 20, Score = 8 };

            bool status = sv.addStudent(s);
            Assert.IsTrue(status);

            int size = sv.size();
            Assert.AreEqual(1, size);
        }
    }
}