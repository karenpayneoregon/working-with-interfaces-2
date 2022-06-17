using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson00.Interfaces
{

    public interface IBaseEntity
    {
        public int Id { get; }
        public string Name { get; set; }

        /// <summary>
        /// With C# 8 and higher we can add a method and not break current
        /// code while before C# 8 this would break existing code.
        /// </summary>
        public virtual string DoSomething(string value)
        {
            return "Default";
        }
    }

    #region Default implementations of interface members

    public interface ILogger
    {
        void Info(string message);
        void Error(string message);
    }
    //public interface ILogger
    //{
    //    void Info(string message);
    //    void Error(string message);

    //    // New method
    //    void Warn(string message)
    //    {
    //        Console.WriteLine(message);
    //    }
    //}

    #endregion
}
