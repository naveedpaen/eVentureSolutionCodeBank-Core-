namespace FirstDayWithOOP
{

   public class Student:Human//Inheritance (IS A)
    {
        public Student(Address address)
        {
            Name = "Empty";
            FatherName = "Empty";
            RollNumber = 00;


            //Composition
            Course=new Course();

            //Aggregation
            Address = address;
        }


        //Association (HAS A)
        private Course course;

        public Course Course
        {
            get { return course; }
            set { course = value; }
        }



        private int    rollNumber;
     
        public int RollNumber
        {
            set
            {
                if (value > 0 && value < 1000)
                {
                    rollNumber = value;
                }
            }
            get { return rollNumber; }
        }

       


    }
}