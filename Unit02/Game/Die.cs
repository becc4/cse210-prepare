using System;


namespace Unit02.Game
{
    public class Die { // Actor
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.
        /// <summary>
        /// A small cube with a different number of spots on each of its six sides.
        /// 
        /// The responsibility of Die is to keep track of its currently rolled value and the points its
        /// worth.
        /// </summary> 
        public int _points = 0;
        public int _value = 0;

    // 2) Create the class constructor. Use the following method comment.

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        public Die(){}
    
    // 3) Create the Roll() method. Use the following method comment.
        public void Roll() {
        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
        /// </summary>
            Random randomGenerator = new Random();
            _value = randomGenerator.Next(1,7);

            if (_value == 1) {
                _points = 100;
            } else if (_value == 5) {
                _points = 50;
            } else {
                _points = 0;
            }
        }
    }
}