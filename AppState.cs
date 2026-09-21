using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Queeless
{
    public enum UserRole { Student, Lecturer, Admin}
    public class MenuItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public MenuItem(string id, string name, decimal price) 
        {

            Id = id;
            Name = name;
            Price = price;
        
        }
        public static class AppState 
        {
            public static UserRole CurrentRole { get; set; } = UserRole.Student;
            public static List<MenuItem> CartItems { get; } = new List<MenuItem>();

            public static void AddToCart (MenuItem item) 
            {
                CartItems.Add(item);
            }

            public static int GetCartCount() 
            {
                return CartItems.Count;
            }
            
        }

    }
}
