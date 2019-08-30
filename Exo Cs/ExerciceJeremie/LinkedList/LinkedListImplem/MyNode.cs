namespace LinkedListImplem
{
    public class MyNode
    {
        private object _value;
        private MyNode _next;

        /// <summary>
        /// Construct a new node from a value and his next one
        /// </summary>
        /// <param name="value">Value of the node</param>
        /// <param name="next">Node next to this</param>
        public MyNode(object value, MyNode next)
        {
            this._value = value;
            this._next = next;
        }

        /// <summary>
        /// Sets the next node of this
        /// </summary>
        /// <param name="next">Next node</param>
        public void SetNext(MyNode next)
        {
            this._next = next;
        }

        /// <summary>
        /// Gets the next node of this
        /// </summary>
        /// <returns>The next node</returns>
        public MyNode GetNext()
        {
            return this._next;
        }

        /// <summary>
        /// Sets the object of this node
        /// </summary>
        /// <param name="obj">Object</param>
        public void SetObject(object obj)
        {
            this._value = obj;
        }

        /// <summary>
        /// Gets the object of this node
        /// </summary>
        /// <returns>Tue object</returns>
        public object GetObject()
        {
            return this._value;
        }
    }
}