using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentmanagementsystem
{
	interface UserInterface
	{
		public void showFirstScreen();
		public void showStudentScreen();
		public void showAdminScreen();
		public void showAllStudentsScreen();
		public void showStudentRegistrationScreen();
		public void introduceNewCourseScreen();
		public void showAllCoursesScreen();
	}
}
