namespace LinkedListImplem
{
    public class MyLinkedList
    {
        private MyNode _begin;

        public MyLinkedList()
        {
        }

        /// <summary>
        /// Gets the first element of the list
        /// </summary>
        /// <returns>The first element of the list</returns>
        public object GetFirst()
        {
            return default(object);
        }

        /// <summary>
        /// Gets the last element of the list
        /// </summary>
        /// <returns>The last element</returns>
        public object GetLast()
        {
            return default(object);
        }

        /// <summary>
        /// Insert the given element at the end of the list
        /// </summary>
        /// <param name="obj">object to insert</param>
        public void PushBack(object obj)
        {

        }

        /// <summary>
        /// Insert the given element at the begining of the list
        /// </summary>
        /// <param name="obj">object to insert</param>
        public void PushFront(object obj)
        {

        }


        /// <summary>
        /// Gets an element at a given  index
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>The element</returns>
        public object GetAt(int index)
        {
            return default(object);
        }

        /// <summary>
        /// Gets the number of elements in the list
        /// </summary>
        /// <returns>An int representing the number of element in the list</returns>
        public int GetCount()
        {
            int c = 0;
            for (MyNode i = this._begin; i != null; i = i.GetNext())
            {
                c = c + 1;
            }
            return c;
        }

        /// <summary>
        /// Insert the given object at the given index
        /// </summary>
        /// <param name="index">Index to insert at</param>
        /// <param name="obj">Object to insert</param>
        public void InsertAt(int index, object obj)
        {

        }

        /// <summary>
        /// Insert the given object after the given target
        /// </summary>
        /// <param name="target">Target to insert afert</param>
        /// <param name="toInsert">Object to insert</param>
        public void InsertAfert(object target, object toInsert)
        {

        }

        /// <summary>
        /// Insert the given object before the given target
        /// </summary>
        /// <param name="target">Target to insert before</param>
        /// <param name="toInsert">Object to insert</param>
        public void InsertBefore(object target, object toInsert)
        {

        }

        /// <summary>
        /// Remove elements from an index to another
        /// </summary>
        /// <param name="beginIndex">Index from where to begin removing</param>
        /// <param name="nb">number of elements to remove</param>
        /// <returns>The number of removed elements</returns>
        public int Remove(int beginIndex, int nb)
        {
            return default(int);
        }

        /// <summary>
        /// Remove the given object from the list
        /// </summary>
        /// <param name="value">Object to remove</param>
        /// <returns>Number of elements removed</returns>
        public int Remove(object value)
        {
            return default(int);
        }
    }
}