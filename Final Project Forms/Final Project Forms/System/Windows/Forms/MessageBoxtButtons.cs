namespace System.Windows.Forms
{
    internal class MessageBoxtButtons
    {
        public MessageBoxtButtons()
        {
        }

        public static implicit operator MessageBoxDefaultButton(MessageBoxtButtons v)
        {
            throw new NotImplementedException();
        }
    }
}