using CASHDISPENSER3Lib;
using PINPAD3Lib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace AxCASHDISPENSER3Lib
{
    public class _IAXFS3CashDispenserEvents_CalibrateFailedEvent : EventArgs {
        public ICDMCashUnitList cashUnits { get; set; }
    }
    public class _IAXFS3CashDispenserEvents_CalibrateOKEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_CashUnitErrorEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_CashUnitInfoChangedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_CashUnitThresholdEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_CloseSessionFailedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_CloseSessionOKEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_ConnectionLostEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_DeviceStatusChangedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_DispenseFailedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_DispenseOKEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_DispenseStartedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_OpenSessionFailedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_OpenSessionOKEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_GetCashUnitInfoFailedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_GetCashUnitInfoOKEvent : EventArgs {
        public ICDMCashUnitList cashUnits;
    }
    public class _IAXFS3CashDispenserEvents_GetDeviceStatusFailedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_GetDeviceStatusOKEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_GetLastPresentStatusFailedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_GetLastPresentStatusOKEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_HardwareErrorEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_IncompleteDispenseEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_ItemsPresentedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_ItemsTakenEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_NoteErrorEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_OpenSafeDoorFailedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_OpenSafeDoorOKEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_OpenShutterFailedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_OpenShutterOKEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_PartialDispenseEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_PartialDispenseOKEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_PresentFailedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_PresentOKEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_RejectFailedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_RejectOKEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_ResetFailedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_ResetOKEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_ReleaseLockFailedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_ReleaseLockOKEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_RequestLockFailedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_RequestLockGrantedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_RequestLockTimeOutEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_RetractFailedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_RetractOKEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_SafeDoorClosedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_SafeDoorOpenEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_SoftwareErrorEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_TestCashUnitsFailedEvent : EventArgs { }
    public class _IAXFS3CashDispenserEvents_TestCashUnitsOKEvent : EventArgs { }

    public delegate void axAXFS3CashDispenser1_CausesValidationChangedEventHandler(Object sender, EventArgs o);

    public delegate void _IAXFS3CashDispenserEvents_CalibrateFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_CalibrateFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_CalibrateOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_CalibrateOKEvent o);
    public delegate void _IAXFS3CashDispenserEvents_CashUnitErrorEventHandler(Object sender, _IAXFS3CashDispenserEvents_CashUnitErrorEvent o);
    public delegate void _IAXFS3CashDispenserEvents_CashUnitInfoChangedEventHandler(Object sender, _IAXFS3CashDispenserEvents_CashUnitInfoChangedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_CashUnitThresholdEventHandler(Object sender, _IAXFS3CashDispenserEvents_CashUnitThresholdEvent o);
    public delegate void _IAXFS3CashDispenserEvents_CloseSessionFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_CloseSessionFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_CloseSessionOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_CloseSessionOKEvent o);
    public delegate void _IAXFS3CashDispenserEvents_ConnectionLostEventHandler(Object sender, _IAXFS3CashDispenserEvents_ConnectionLostEvent o);
    public delegate void _IAXFS3CashDispenserEvents_DeviceStatusChangedEventHandler(Object sender, _IAXFS3CashDispenserEvents_DeviceStatusChangedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_DispenseFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_DispenseFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_DispenseOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_DispenseOKEvent o);
    public delegate void _IAXFS3CashDispenserEvents_DispenseStartedEventHandler(Object sender, _IAXFS3CashDispenserEvents_DispenseStartedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_OpenSessionFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_OpenSessionFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_OpenSessionOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_OpenSessionOKEvent o);
    public delegate void _IAXFS3CashDispenserEvents_GetCashUnitInfoFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_GetCashUnitInfoFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_GetCashUnitInfoOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_GetCashUnitInfoOKEvent o);
    public delegate void _IAXFS3CashDispenserEvents_GetDeviceStatusFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_GetDeviceStatusFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_GetDeviceStatusOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_GetDeviceStatusOKEvent o);
    public delegate void _IAXFS3CashDispenserEvents_GetLastPresentStatusFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_GetLastPresentStatusFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_GetLastPresentStatusOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_GetLastPresentStatusOKEvent o);
    public delegate void _IAXFS3CashDispenserEvents_HardwareErrorEventHandler(Object sender, _IAXFS3CashDispenserEvents_HardwareErrorEvent o);
    public delegate void _IAXFS3CashDispenserEvents_IncompleteDispenseEventHandler(Object sender, _IAXFS3CashDispenserEvents_IncompleteDispenseEvent o);
    public delegate void _IAXFS3CashDispenserEvents_ItemsPresentedEventHandler(Object sender, _IAXFS3CashDispenserEvents_ItemsPresentedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_ItemsTakenEventHandler(Object sender, _IAXFS3CashDispenserEvents_ItemsTakenEvent o);
    public delegate void _IAXFS3CashDispenserEvents_NoteErrorEventHandler(Object sender, _IAXFS3CashDispenserEvents_NoteErrorEvent o);
    public delegate void _IAXFS3CashDispenserEvents_OpenSafeDoorFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_OpenSafeDoorFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_OpenSafeDoorOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_OpenSafeDoorOKEvent o);
    public delegate void _IAXFS3CashDispenserEvents_OpenShutterFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_OpenShutterFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_OpenShutterOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_OpenShutterOKEvent o);
    public delegate void _IAXFS3CashDispenserEvents_PartialDispenseEventHandler(Object sender, _IAXFS3CashDispenserEvents_PartialDispenseEvent o);
    public delegate void _IAXFS3CashDispenserEvents_PartialDispenseOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_PartialDispenseOKEvent o);
    public delegate void _IAXFS3CashDispenserEvents_PresentFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_PresentFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_PresentOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_PresentOKEvent o);
    public delegate void _IAXFS3CashDispenserEvents_RejectFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_RejectFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_RejectOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_RejectOKEvent o);
    public delegate void _IAXFS3CashDispenserEvents_ResetFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_ResetFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_ResetOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_ResetOKEvent o);
    public delegate void _IAXFS3CashDispenserEvents_ReleaseLockFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_ReleaseLockFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_ReleaseLockOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_ReleaseLockOKEvent o);
    public delegate void _IAXFS3CashDispenserEvents_RequestLockFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_RequestLockFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_RequestLockGrantedEventHandler(Object sender, _IAXFS3CashDispenserEvents_RequestLockGrantedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_RequestLockTimeOutEventHandler(Object sender, _IAXFS3CashDispenserEvents_RequestLockTimeOutEvent o);
    public delegate void _IAXFS3CashDispenserEvents_RetractFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_RetractFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_RetractOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_RetractOKEvent o);
    public delegate void _IAXFS3CashDispenserEvents_SafeDoorClosedEventHandler(Object sender, _IAXFS3CashDispenserEvents_SafeDoorClosedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_SafeDoorOpenEventHandler(Object sender, _IAXFS3CashDispenserEvents_SafeDoorOpenEvent o);
    public delegate void _IAXFS3CashDispenserEvents_SoftwareErrorEventHandler(Object sender, _IAXFS3CashDispenserEvents_SoftwareErrorEvent o);
    public delegate void _IAXFS3CashDispenserEvents_TestCashUnitsFailedEventHandler(Object sender, _IAXFS3CashDispenserEvents_TestCashUnitsFailedEvent o);
    public delegate void _IAXFS3CashDispenserEvents_TestCashUnitsOKEventHandler(Object sender, _IAXFS3CashDispenserEvents_TestCashUnitsOKEvent o);

    public class AxAXFS3CashDispenser : Panel
    {
        public static List<AxAXFS3CashDispenser> Instances = new List<AxAXFS3CashDispenser>();
        
        public event _IAXFS3CashDispenserEvents_CalibrateFailedEventHandler CalibrateFailed;
        public event _IAXFS3CashDispenserEvents_CalibrateOKEventHandler CalibrateOK;
        public event _IAXFS3CashDispenserEvents_CashUnitErrorEventHandler CashUnitError;
        public event _IAXFS3CashDispenserEvents_CashUnitInfoChangedEventHandler CashUnitInfoChanged;
        public event _IAXFS3CashDispenserEvents_CashUnitThresholdEventHandler CashUnitThreshold;
        public event _IAXFS3CashDispenserEvents_CloseSessionFailedEventHandler CloseSessionFailed;
        public event _IAXFS3CashDispenserEvents_CloseSessionOKEventHandler CloseSessionOK;
        public event _IAXFS3CashDispenserEvents_ConnectionLostEventHandler ConnectionLost;
        public event _IAXFS3CashDispenserEvents_DeviceStatusChangedEventHandler DeviceStatusChanged;
        public event _IAXFS3CashDispenserEvents_DispenseFailedEventHandler DispenseFailed;
        public event _IAXFS3CashDispenserEvents_DispenseOKEventHandler DispenseOK;
        public event _IAXFS3CashDispenserEvents_DispenseStartedEventHandler DispenseStarted;
        public event _IAXFS3CashDispenserEvents_OpenSessionFailedEventHandler OpenSessionFailed;
        public event _IAXFS3CashDispenserEvents_OpenSessionOKEventHandler OpenSessionOK;
        public event _IAXFS3CashDispenserEvents_GetCashUnitInfoFailedEventHandler GetCashUnitInfoFailed;
        public event _IAXFS3CashDispenserEvents_GetCashUnitInfoOKEventHandler GetCashUnitInfoOK;
        public event _IAXFS3CashDispenserEvents_GetDeviceStatusFailedEventHandler GetDeviceStatusFailed;
        public event _IAXFS3CashDispenserEvents_GetDeviceStatusOKEventHandler GetDeviceStatusOK;
        public event _IAXFS3CashDispenserEvents_GetLastPresentStatusFailedEventHandler GetLastPresentStatusFailed;
        public event _IAXFS3CashDispenserEvents_GetLastPresentStatusOKEventHandler GetLastPresentStatusOK;
        public event _IAXFS3CashDispenserEvents_HardwareErrorEventHandler HardwareError;
        public event _IAXFS3CashDispenserEvents_IncompleteDispenseEventHandler IncompleteDispense;
        public event _IAXFS3CashDispenserEvents_ItemsPresentedEventHandler ItemsPresented;
        public event _IAXFS3CashDispenserEvents_ItemsTakenEventHandler ItemsTaken;
        public event _IAXFS3CashDispenserEvents_NoteErrorEventHandler NoteError;
        public event _IAXFS3CashDispenserEvents_OpenSafeDoorFailedEventHandler OpenSafeDoorFailed;
        public event _IAXFS3CashDispenserEvents_OpenSafeDoorOKEventHandler OpenSafeDoorOK;
        public event _IAXFS3CashDispenserEvents_OpenShutterFailedEventHandler OpenShutterFailed;
        public event _IAXFS3CashDispenserEvents_OpenShutterOKEventHandler OpenShutterOK;
        public event _IAXFS3CashDispenserEvents_PartialDispenseEventHandler PartialDispense;
        public event _IAXFS3CashDispenserEvents_PartialDispenseOKEventHandler PartialDispenseOK;
        public event _IAXFS3CashDispenserEvents_PresentFailedEventHandler PresentFailed;
        public event _IAXFS3CashDispenserEvents_PresentOKEventHandler PresentOK;
        public event _IAXFS3CashDispenserEvents_RejectFailedEventHandler RejectFailed;
        public event _IAXFS3CashDispenserEvents_RejectOKEventHandler RejectOK;
        public event _IAXFS3CashDispenserEvents_ResetFailedEventHandler ResetFailed;
        public event _IAXFS3CashDispenserEvents_ResetOKEventHandler ResetOK;
        public event _IAXFS3CashDispenserEvents_ReleaseLockFailedEventHandler ReleaseLockFailed;
        public event _IAXFS3CashDispenserEvents_ReleaseLockOKEventHandler ReleaseLockOK;
        public event _IAXFS3CashDispenserEvents_RequestLockFailedEventHandler RequestLockFailed;
        public event _IAXFS3CashDispenserEvents_RequestLockGrantedEventHandler RequestLockGranted;
        public event _IAXFS3CashDispenserEvents_RequestLockTimeOutEventHandler RequestLockTimeOut;
        public event _IAXFS3CashDispenserEvents_RetractFailedEventHandler RetractFailed;
        public event _IAXFS3CashDispenserEvents_RetractOKEventHandler RetractOK;
        public event _IAXFS3CashDispenserEvents_SafeDoorClosedEventHandler SafeDoorClosed;
        public event _IAXFS3CashDispenserEvents_SafeDoorOpenEventHandler SafeDoorOpen;
        public event _IAXFS3CashDispenserEvents_SoftwareErrorEventHandler SoftwareError;
        public event _IAXFS3CashDispenserEvents_TestCashUnitsFailedEventHandler TestCashUnitsFailed;
        public event _IAXFS3CashDispenserEvents_TestCashUnitsOKEventHandler TestCashUnitsOK;

        public string DeviceName { get; set; }
        public State OcxState { get; set; }

        public AxAXFS3CashDispenser() : base()
        {
            Instances.Add(this);
        }


        public Int32 GetCashUnitInfo()
        {
            var tmpObj = new _IAXFS3CashDispenserEvents_GetCashUnitInfoOKEvent();
            tmpObj.cashUnits = new CDMCashUnitList();
            GetCashUnitInfoOK(this, tmpObj);
            return 1;
        }

        public void Reject()
        {
            //MessageBox.Show("Reject");
        }

        public Int32 OpenSession()
        {
            OpenSessionOK(this, new _IAXFS3CashDispenserEvents_OpenSessionOKEvent());
            return 1;
        }

        public void CloseSession()
        {
            CloseSessionOK(this, new _IAXFS3CashDispenserEvents_CloseSessionOKEvent());
        }

        public Int32 Dispense(Int16 i1, Int16 i2, CDMPosition position, Boolean b, CDMDenomination o)
        {
            var startInfo = new ProcessStartInfo();
            startInfo.FileName = "DispenseMoney.bat";
            startInfo.UseShellExecute = true;
            Process.Start(startInfo);
            DispenseOK(this, new _IAXFS3CashDispenserEvents_DispenseOKEvent());
            return 1;
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
