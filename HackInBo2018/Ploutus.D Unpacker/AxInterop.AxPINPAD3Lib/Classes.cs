using CASHDISPENSER3Lib;
using PINPAD3Lib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace AxPINPAD3Lib
{    
    public class _IAXFS3PinPadEvents_SoftwareErrorEvent : EventArgs { }
    public class _IAXFS3PinPadEvents_HardwareErrorEvent : EventArgs { }
    public class _IAXFS3PinPadEvents_ReadDataFailedEvent : EventArgs { }
    public class _IAXFS3PinPadEvents_ReadDataOKEvent : EventArgs { public String keys; }
    public class _IAXFS3PinPadEvents_KeyPressEvent : EventArgs
    {
        public Int16 digit;
        public Int16 completion;
    }
    public class _IAXFS3PinPadEvents_RequestLockFailedEvent : EventArgs { }
    public class _IAXFS3PinPadEvents_RequestLockGrantedEvent : EventArgs { }
    public class _IAXFS3PinPadEvents_RequestLockTimeOutEvent : EventArgs { }
    public class _IAXFS3PinPadEvents_InitializedEvent : EventArgs { public String key; }
    public class _IAXFS3PinPadEvents_InitializeFailedEvent : EventArgs { }
    public class _IAXFS3PinPadEvents_OpenSessionFailedEvent : EventArgs { }
    public class _IAXFS3PinPadEvents_OpenSessionOKEvent : EventArgs { }
    public class _IAXFS3PinPadEvents_GetDeviceStatusFailedEvent : EventArgs { public String status; }
    public class _IAXFS3PinPadEvents_GetDeviceStatusOKEvent : EventArgs { public String status; }
    public class _IAXFS3PinPadEvents_ResetOKEvent : EventArgs { }
    public class _IAXFS3PinPadEvents_ResetFailedEvent : EventArgs { }
    public class _IAXFS3PinPadEvents_ReleaseLockOKEvent : EventArgs { }
    public class _IAXFS3PinPadEvents_ReleaseLockFailedEvent : EventArgs { }

    // delegates
    public delegate void _IAXFS3PinPadEvents_SoftwareErrorEventHandler(Object sender, _IAXFS3PinPadEvents_SoftwareErrorEvent o);
    public delegate void _IAXFS3PinPadEvents_HardwareErrorEventHandler(Object sender, _IAXFS3PinPadEvents_HardwareErrorEvent o);
    public delegate void _IAXFS3PinPadEvents_ReadDataFailedEventHandler(Object sender, _IAXFS3PinPadEvents_ReadDataFailedEvent o);
    public delegate void _IAXFS3PinPadEvents_ReadDataOKEventHandler(Object sender, _IAXFS3PinPadEvents_ReadDataOKEvent o);
    public delegate void _IAXFS3PinPadEvents_KeyPressEventHandler(Object sender, _IAXFS3PinPadEvents_KeyPressEvent o);
    public delegate void _IAXFS3PinPadEvents_RequestLockFailedEventHandler(Object sender, _IAXFS3PinPadEvents_RequestLockFailedEvent o);
    public delegate void _IAXFS3PinPadEvents_RequestLockGrantedEventHandler(Object sender, _IAXFS3PinPadEvents_RequestLockGrantedEvent o);
    public delegate void _IAXFS3PinPadEvents_RequestLockTimeOutEventHandler(Object sender, _IAXFS3PinPadEvents_RequestLockTimeOutEvent o);
    public delegate void _IAXFS3PinPadEvents_InitializedEventHandler(Object sender, _IAXFS3PinPadEvents_InitializedEvent o);
    public delegate void _IAXFS3PinPadEvents_InitializeFailedEventHandler(Object sender, _IAXFS3PinPadEvents_InitializeFailedEvent o);
    public delegate void _IAXFS3PinPadEvents_OpenSessionFailedEventHandler(Object sender, _IAXFS3PinPadEvents_OpenSessionFailedEvent o);
    public delegate void _IAXFS3PinPadEvents_OpenSessionOKEventHandler(Object sender, _IAXFS3PinPadEvents_OpenSessionOKEvent o);
    public delegate void _IAXFS3PinPadEvents_GetDeviceStatusFailedEventHandler(Object sender, _IAXFS3PinPadEvents_GetDeviceStatusFailedEvent o);
    public delegate void _IAXFS3PinPadEvents_GetDeviceStatusOKEventHandler(Object sender, _IAXFS3PinPadEvents_GetDeviceStatusOKEvent o);
    public delegate void _IAXFS3PinPadEvents_ResetOKEventHandler(Object sender, _IAXFS3PinPadEvents_ResetOKEvent o);
    public delegate void _IAXFS3PinPadEvents_ResetFailedEventHandler(Object sender, _IAXFS3PinPadEvents_ResetFailedEvent o);
    public delegate void _IAXFS3PinPadEvents_ReleaseLockOKEventHandler(Object sender, _IAXFS3PinPadEvents_ReleaseLockOKEvent o);
    public delegate void _IAXFS3PinPadEvents_ReleaseLockFailedEventHandler(Object sender, _IAXFS3PinPadEvents_ReleaseLockFailedEvent o);
    
    public class AxAXFS3PinPad : Panel
    {
        public event _IAXFS3PinPadEvents_SoftwareErrorEventHandler SoftwareError;
        public event _IAXFS3PinPadEvents_HardwareErrorEventHandler HardwareError;
        public event _IAXFS3PinPadEvents_ReadDataFailedEventHandler ReadDataFailed;
        public event _IAXFS3PinPadEvents_ReadDataOKEventHandler ReadDataOK;
        public event _IAXFS3PinPadEvents_KeyPressEventHandler KeyPressEvent;
        public event _IAXFS3PinPadEvents_RequestLockFailedEventHandler RequestLockFailed;
        public event _IAXFS3PinPadEvents_RequestLockGrantedEventHandler RequestLockGranted;
        public event _IAXFS3PinPadEvents_RequestLockTimeOutEventHandler RequestLockTimeOut;
        public event _IAXFS3PinPadEvents_InitializedEventHandler Initialized;
        public event _IAXFS3PinPadEvents_InitializeFailedEventHandler InitializeFailed;
        public event _IAXFS3PinPadEvents_OpenSessionFailedEventHandler OpenSessionFailed;
        public event _IAXFS3PinPadEvents_OpenSessionOKEventHandler OpenSessionOK;
        public event _IAXFS3PinPadEvents_GetDeviceStatusFailedEventHandler GetDeviceStatusFailed;
        public event _IAXFS3PinPadEvents_GetDeviceStatusOKEventHandler GetDeviceStatusOK;
        public event _IAXFS3PinPadEvents_ResetOKEventHandler ResetOK;
        public event _IAXFS3PinPadEvents_ResetFailedEventHandler ResetFailed;
        public event _IAXFS3PinPadEvents_ReleaseLockOKEventHandler ReleaseLockOK;
        public event _IAXFS3PinPadEvents_ReleaseLockFailedEventHandler ReleaseLockFailed;

        public string DeviceName { get; set; }
        public State OcxState { get; set; }

        public static List<AxAXFS3PinPad> Instances = new List<AxAXFS3PinPad>();

        public AxAXFS3PinPad() : base()
        {
            Instances.Add(this);            
        }

        public void TriggerKeyPress(Int16 digit, Int16 completion)
        {
            if (KeyPressEvent != null)
            {
                this.KeyPressEvent(this, new _IAXFS3PinPadEvents_KeyPressEvent() { digit = digit, completion = completion });
            }            
        }


        public void ReadData(PINReadData pinReadData)
        {
            //MessageBox.Show("ReadData");
        }

        public void RequestLock(Int32 time)
        {
            //MessageBox.Show("RequestLock");
        }

        public void Initialize(Object o1, Object o2)
        {
            //MessageBox.Show("Initialize");
        }

        public Int32 OpenSession()
        {
            //MessageBox.Show("OpenSession");
            return 42;
        }

        public void CloseSession()
        {
            //MessageBox.Show("CloseSession");
        }

        public void EndInit()
        {
            //MessageBox.Show("EndInit");
        }

        public void BeginInit()
        {
            //MessageBox.Show("BeginInit");
        }
    }
}
