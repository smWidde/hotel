namespace the_third.Presenters.Results
{
    public class DataResult<T> : IResult
    {
        private T dataItem;

        public DataResult(T dataItem)
        {
            this.dataItem = dataItem;
        }
        public T DataItem
        {
            get { return dataItem; }
        }
    }
}