using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_assignment
{
    internal class EventScore
    {
        private string _name;
        private string _eventName;
        private double _totalScore;
        public EventScore(string name, string eventName, double totalScore)
        {
            _name = name;
            _eventName = eventName;
            _totalScore = totalScore;
        }
        /// <summary>
        /// Gets the name and returns it as a string value.
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        /// <summary>
        /// Gets the event name and returns it as a string value.
        /// </summary>
        public string EventName { get { return this._eventName; } }
        /// <summary>
        /// Returns the total score.
        /// </summary>
        public double GetTotalScore { get { return this._totalScore; } }
        /// <summary>
        /// The average score that judges gave (assuming there are 5 judges)
        /// </summary>
        public double GetAverage
        {
            get
            {
                return (this._totalScore / 5);
            }
        }
        /// <summary>
        /// Ovverides to string in order to print the name, event and total scor.
        /// </summary>
        /// <returns>Name: {name}, Event: {eventName}, Total Score: {totalScore}</returns>
        public override string ToString()
        {
            return $"Name: {this._name}, Event: {this._eventName}, Total Score: {this._totalScore}";
        }
    }
}
