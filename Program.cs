using System;

class StopWatch
{
    private long startTime;
    private long endTime;

    public StopWatch()
    {
        Start();
    }

    public void Start()
    {
        startTime = System.DateTime.Now.Ticks;
    }

    public void Stop()
    {
        endTime = System.DateTime.Now.Ticks;
    }

    public long GetElapsedTime()
    {
        return endTime - startTime;
    }
}

class SelectionSort
{
    static void Main(string[] args)
    {
        int[] numbers = new int[100000]; // 100,000 số

        // Khởi tạo mảng với giá trị ngẫu nhiên
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next();
        }

        // Tạo stopwatch và bắt đầu đo thời gian
        StopWatch stopwatch = new StopWatch();

        // Thực hiện thuật toán sắp xếp chọn
        for (int i = 0; i < numbers.Length; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }
            if (i != minIndex)
            {
                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }
        }

        // Dừng đo thời gian và hiển thị kết quả
        stopwatch.Stop();
        long elapsedTime = stopwatch.GetElapsedTime();
        Console.WriteLine("Thời gian thực thi thuật toán sắp xếp chọn: {0} ms", elapsedTime);
    }
}