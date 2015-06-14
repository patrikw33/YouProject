using System;


namespace EdxModThreeAssignment
{
    class Program
    {       
        
        static void Main(string[] args)
        {
            Console.WriteLine("Press one of the keys below  plus Enter for the needed information");
            Console.WriteLine();
            bool end = false;
            while(end == false) 
            {             
               
                Console.WriteLine("Press 1 for Student information");
                Console.WriteLine("Press 2 for Teacher information");
                Console.WriteLine("Press 3 for Course information");
                Console.WriteLine("Press 4 for Program information");
                Console.WriteLine("Press 5 for Degree information");
                Console.WriteLine();
                Console.WriteLine("Press 6 + Enter to throw  a NotimplementedException");
                Console.WriteLine("Press any other number + ENTER  to quit the program");
               

                int userInputToInteger = int.Parse(Console.ReadLine());

                // The switch statement will execute accordingly to user input.
                switch (userInputToInteger)
                {
                    case 1:
                        GetStudentDetails();
                        break;
                    case 2:
                        GetTeacherInfo();
                        break;
                    case 3:
                        GetCourseInfo();
                        break;
                    case 4:
                        GetProgramInfo();
                        break;
                    case 5:
                        GetDegreeDetails();
                        break;
                    case 6:                                
                       
                        IsValidateBirthday();  // Calling this method will crash the program.
                        break;

                    default:
                        Console.WriteLine("Thank");
                        end = true;
                        break;
                }
              //  Console.WriteLine();

            }
            Console.WriteLine("\n");         
        
        }
        /// <summary>
        /// This method prompts the user to input student  information, which will be assigned 
        /// to the appropriate variables and then past to print method as parameters    
        /// </summary>
        public static void GetStudentDetails()
        {
            string firstName, lastName, birthdayText;
            DateTime birthday;
            

            Console.Write("Enter student's First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter Student's Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Enter Student's birthday in format  DD-MM-YYYY format: ");
            birthdayText  = Console.ReadLine();
            birthday = Convert.ToDateTime(birthdayText);
            Console.WriteLine("\n");
            
            PrintStudentDetails(firstName, lastName, birthday); 
            
        }
        /// <summary>
        /// Get the Teacher information and calls print method to print the information.
        /// </summary>
        public static void GetTeacherInfo()
        {
            string firstName, lastName , country, birthdayString;
            DateTime birthday;

            Console.Write("Enter Teacher's First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter Teacher's Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Enter Teacher's Country: ");
            country = Console.ReadLine();
            Console.Write("Enter Teacher's birthday in format  DD-MM-YYYY format: ");
            birthdayString = Console.ReadLine();
            birthday = Convert.ToDateTime(birthdayString);
            Console.WriteLine("\n");
            //Print teacher's information on the screen. 
            PrintTeacherInfo(firstName, lastName, birthday, country);          
        }
        /// <summary>
        /// Get the Course information and print them on console window by calling print function.
        /// </summary>
        public static void GetCourseInfo()
        {
            string courseName, teacher;
            int durationInWeek;        

            Console.Write("Enter Course Name: ");
            courseName = Console.ReadLine();

            Console.Write("Enter Teacher Name: ");
            teacher = Console.ReadLine();

            Console.Write("Enter enter the duration in week (number): ");
            durationInWeek = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            
            PrintCourseInfo(courseName, durationInWeek, teacher); // call Print method.

        }
        /// <summary>
        /// Get user input and calls print method.        
        /// </summary>
        public static void GetProgramInfo()
        {
            string programName, departHead,degrees;           

            Console.Write("Enter the Program Name: ");
            programName = Console.ReadLine();

            Console.Write("Enter the Department Head: ");
            departHead = Console.ReadLine();

            Console.Write("Enter the degrees: ");
            degrees = Console.ReadLine();
            Console.WriteLine("\n");
           
            PrintUProgramInfo(programName, departHead, degrees);

        }
        /// <summary>
        /// This method prompts the user to input student degree information and then calls the print method.
        /// </summary>
        public static void GetDegreeDetails()
        {
            string degreeName, studentName, creditString;
            int creditRequired;
            

            Console.Write("Enter the degree Name: ");
            degreeName = Console.ReadLine();

            Console.Write("Enter the required credit: ");
            creditString = Console.ReadLine();
            creditRequired = int.Parse(creditString);

            Console.Write("Enter Student's Name:  ");
            studentName = Console.ReadLine();
            Console.WriteLine("\n");

            PrintDegreeInfo(degreeName,creditRequired, studentName);

        }       
        /// <summary>
        /// Print student information  to console window.
        /// </summary>
        
        public static void PrintStudentDetails(string firstName, string lastName, DateTime birthday)
        {

            Console.WriteLine("{0,-20} {1, -20} {2, -30}", "First Name", "Last Name", "Birthday");

            Console.WriteLine("{0,-20} {1, -20} {2, -30}", "----------", "-----------", "------------");

            Console.WriteLine("{0,-20} {1, -20} {2, -30}", firstName, lastName, birthday.ToString("MMM dd, yyyy"));
            Console.WriteLine();
        }

        /// <summary>
        /// This method gets Teacher information as parameters and print them to console window
        /// </summary>
     
        public static void PrintTeacherInfo(string firstName, string lastName, DateTime birthday, string country)
        {
            Console.WriteLine("{0,-20} {1, -20} {2, -20} {2, -20}", "First Name", "Last Name", "Birthday", "Country");

            Console.WriteLine("{0,-20} {1, -20} {2, -20} {2, -20}", "----------", "-----------", "------------", "------------");

            Console.WriteLine("{0,-20} {1, -20} {2, -20} {2, -20}", firstName, lastName, birthday.ToString("MMM dd, yyyy"), country);
            Console.WriteLine();
        }

        /// <summary>
        /// Method to print Course Information.
        /// </summary>
       
        public static void PrintCourseInfo(string courseName, int durationInWeek, string teacherName)
        {
            Console.WriteLine("{0,-20} {1, -20} {2, -30}", "Course Name", "Duration in Week", "Teacher Name");

            Console.WriteLine("{0,-20} {1, -20} {2, -20}", "----------", "-----------", "------------");

            Console.WriteLine("{0,-20} {1, -20} {2, -20}", courseName, durationInWeek, teacherName);
            Console.WriteLine();
           
        }
        /// <summary>
        /// This method prints Program information to console window.
        /// </summary>
       
        public static void PrintUProgramInfo(string programName, string departHead, string degree)
        {
            Console.WriteLine("{0,-20} {1, -20} {2, -30}", "Program Name", "Departement Head", "Degrees");

            Console.WriteLine("{0,-20} {1, -20} {2, -20}", "----------", "-----------", "------------");

            Console.WriteLine("{0,-20} {1, -20} {2, -20}", programName, departHead, degree);

        }
        /// <summary>
        /// This method gets the degree information and prints them to console window
        /// </summary>       
        public static void PrintDegreeInfo(string degreeName, int creditRequired, string studentName)
        {
            Console.WriteLine("{0,-20} {1, -20} {2, -30}", "Degree Name", "Credit Required", "Student Name");

            Console.WriteLine("{0,-20} {1, -20} {2, -20}", "----------", "-----------", "------------");

            Console.WriteLine("{0,-20} {1, -20} {2, -20}", degreeName, creditRequired, studentName);

        }
        /// <summary>
        /// This method will throw  NotImplementedException.
        /// </summary>       
        public static void IsValidateBirthday()
        {
            throw new NotImplementedException();
        }
    }
}
