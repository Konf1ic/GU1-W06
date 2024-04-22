using System;

class FanRun
{
    static void Main(string[] args)
    {
        // Tạo hai đối tượng Fan
        Fan fan1 = new Fan();
        Fan fan2 = new Fan();

        // Cấu hình fan1
        fan1.setSpeed(Fan.FAST);
        fan1.setRadius(10);
        fan1.setColor("yellow");
        fan1.setOn(true);

        // Cấu hình fan2
        fan2.setSpeed(Fan.MEDIUM);
        fan2.setRadius(5);
        fan2.setColor("blue");
        fan2.setOn(false);

        // Hiển thị thông tin quạt
        Console.WriteLine("Thông tin quạt 1:");
        Console.WriteLine(fan1);

        Console.WriteLine("\nThông tin quạt 2:");
        Console.WriteLine(fan2);
    }
}
