using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    //1. create a custom Event Arguments
    public class ButtonClickedEventArgs : EventArgs
    {
        public string ClickBy { get; } //read - only property

        public ButtonClickedEventArgs(string ClickBy)
        {
            this.ClickBy = ClickBy;
        }
    }

    //2.Create a class with an Event
    public class Button
    {
        //create an event
        public event EventHandler<ButtonClickedEventArgs> ButtonClicked;

        //Method to stimulate button Click
        public void Click(string user)
        {
            Console.WriteLine("Event Raised");
            OnButtonClicked(new ButtonClickedEventArgs(user));
        }
        //Raise the Event
        protected virtual void OnButtonClicked(ButtonClickedEventArgs e)
        {
            ButtonClicked.Invoke(this, e);
        }
    }

    class EventargDemo
    {
        //event handler
        public static void Button_ButtonClicked(object sender,ButtonClickedEventArgs e)

        {
            Console.WriteLine($"Button was clicked by :{e.ClickBy}");
        }

        public static void Main()
        {
            Button button = new Button();

            //subscribe to the event
            button.ButtonClicked += Button_ButtonClicked;

            button.Click("Bob");
            button.Click("SRI");
        }
    }
}
