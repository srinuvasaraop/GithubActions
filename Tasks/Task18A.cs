    namespace Tasks;

    public class Task18A
    {
        private string Title;
        private int Value;
        private string Category;
        private static int WidgetCount;

        Task18A(string Title1, int Value1, string Category1)
        {
            Title = Title1;
            Value = Value1;
            Category = Category1;
            WidgetCount++;
        }

        public void DisplayWidget()
        {
            Console.WriteLine($"[{Category}] {Title}: {Value} widgetCount: {WidgetCount}");
            Console.ForegroundColor = Category switch
            {
                "Success" => ConsoleColor.Green,
                "Error" => ConsoleColor.Red,
                "Warning" => ConsoleColor.Yellow,
                "Info"    => ConsoleColor.Cyan,
                _         => ConsoleColor.Gray
            };

            Console.WriteLine($"[{Category}] {Title}: {Value} (Total Widgets: {WidgetCount})");
            // Reset to default color after printing
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
                List<Task18A> tasks =
                [
                    new Task18A("Sales", 1200, "Success"),
                    new Task18A("Active Users", 320, "Info"),
                    new Task18A("Pending Orders", 12, "Warning"),
                    new Task18A("Errors Today", 5, "Error"),
                    new Task18A("Subscriptions", 75, "Success")
                ];
            foreach (Task18A task in tasks)
            {
                task.DisplayWidget();
            }
        }
    }