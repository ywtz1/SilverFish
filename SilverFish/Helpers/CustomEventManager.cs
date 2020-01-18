using System;

namespace Silverfish.Helpers
{
    public class MulliganStartedEventArgs
    {
		private bool _ConcedeSuccessfully;

        public bool ConcedeSuccessfully
		{
            get { return _ConcedeSuccessfully; }
			set {_ConcedeSuccessfully=value;}
        }
    }

    public class CustomEventManager
    {
        private CustomEventManager()
        {

        }
		private static CustomEventManager _Instance = new CustomEventManager();
        public static CustomEventManager Instance 
		{ get {return _Instance;} } 

        public event EventHandler<MulliganStartedEventArgs> MulliganStarted;

        public bool OnMulliganStarted()
        {
            MulliganStartedEventArgs eventArgs = new MulliganStartedEventArgs();
            if(MulliganStarted!=null)
			MulliganStarted.Invoke(this, eventArgs);
            return eventArgs.ConcedeSuccessfully;
        }
    }
}
