namespace the_third.Presenters.Results
{
    public class SuccessResult : IResult
    {
        private bool flag;

        public SuccessResult(bool flag)
        {
            this.flag = flag;
        }
        public bool Flag
        {
            get { return flag; }
        }
    }
}