using ConsoleApp27.Models;

IUser user1 = new("Orxan Filankesov", "uiOrxan@bs.edu.az", "Orxan123");
user1.Info();
user1.checkPassword("Orxan123");
user1.checkPassword("Orxan1");
IUser user2 = new("Nihad Ibadzade", "NihadIbadzade@gmail.com", "Nihadi99");
user2.Info();
user2.checkPassword("Nihadi7848");
user2.checkPassword("nihadi8794");

