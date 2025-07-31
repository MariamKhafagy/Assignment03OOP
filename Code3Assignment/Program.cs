namespace Code3Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            #region Q.1
            //What is the primary purpose of an interface in C#?
            //a) To provide a way to implement multiple inheritance

            #endregion

            #region Q.2
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private

            #endregion

            #region Q.3
            //an an interface contain fields in C#?
            //b) No


            #endregion

            #region Q.4
            //n C#, can an interface inherit from another interface?
            //b) Yes, interfaces can inherit from multiple interfaces


            #endregion

            #region Q.5
            //Which keyword is used to implement an interface in a class in C#?
            //d) implements

            #endregion

            #region Q.6
            //Can an interface contain static methods in C#?
            //a) Yes

            #endregion

            #region Q.7
            //In C#, can an interface have explicit access modifiers for its members?
            //b) No, all members are implicitly public

            #endregion

            #region Q.8
            //What is the purpose of an explicit interface implementation in C#?
            //a) To hide the interface members from outside access

            #endregion

            #region Q.9
            //In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructors

            #endregion

            #region Q.10
            //How can a C# class implement multiple interfaces?
            //c) By separating interface names with commas

            #endregion
            #endregion

            #region Part 2 
            #region Q.1
            //Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from IShape. Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information

            //Icircle circle = new Circle(5.5);
            //IRectangle rectangle = new Rectangle(4.0, 6.0);

            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Q.2
            //In this example, we start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser. The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.
            //IAuthenticationService authenticationService = new BasicAuthenticationService();
            //Console.WriteLine("Enter the Username");
            //string username=Console.ReadLine()!;

            //Console.WriteLine("Enter the Passoword");
            //string password=Console.ReadLine()!;

            //Console.WriteLine($"You entered username : {username} , Password : {password} ");

            //if (authenticationService.AuthenticationUser(username, password))
            //{
            //    Console.WriteLine("Authntication Successfull");

            //    Console.WriteLine("Enter role to Check authorization : ");
            //    string role = Console.ReadLine()!;

            //    if (authenticationService.AuthorizeUser(username, role))
            //    {
            //        Console.WriteLine("user  is authorized");


            //    }
            //    else
            //    {
            //        Console.WriteLine("user is not authorized");
            //    }
            //}
            //else
            //{ 
            //  Console.WriteLine("Authentication Failed");
            //}
            #endregion

            #region Q.3
            //we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //string recipient = "user@something.com";
            //string message = "Your order has been Shipped ";

            //emailService.SendNotification(recipient, message);
            //smsService.SendNotification("+657486749", message);
            //pushService.SendNotification("DeviceToken657", message);
            #endregion


            #endregion
        }
    }
}
