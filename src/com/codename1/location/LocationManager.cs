// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.location {
public abstract class LocationManager: global::java.lang.Object {
private static global::com.codename1.location.LocationListener _flistener;

public static int _fAVAILABLE = 0;

public static int _fOUT_1OF_1SERVICE = 1;

public static int _fTEMPORARILY_1UNAVAILABLE = 2;

private int _fstatus;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.location.LocationManager: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    ((global::java.lang.Object) _r1_o).@this();
    _r0.i = 2;
    ((global::com.codename1.location.LocationManager) _r1_o)._fstatus = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.location.LocationManager: void <init>()]
}

public static global::System.Object getLocationManager(){
//XMLVM_BEGIN_WRAPPER[com.codename1.location.LocationManager: com.codename1.location.LocationManager getLocationManager()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0_o = ((global::com.codename1.ui.Display) _r0_o).getLocationManager();
    return (global::com.codename1.location.LocationManager) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.location.LocationManager: com.codename1.location.LocationManager getLocationManager()]
}

public virtual int getStatus(){
//XMLVM_BEGIN_WRAPPER[com.codename1.location.LocationManager: int getStatus()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.location.LocationManager) _r1_o)._fstatus;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.location.LocationManager: int getStatus()]
}

public virtual void setStatus(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.location.LocationManager: void setStatus(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.location.LocationManager) _r0_o)._fstatus = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.location.LocationManager: void setStatus(int)]
}

public abstract global::System.Object getCurrentLocation();

public virtual global::System.Object getCurrentLocationSync(){
//XMLVM_BEGIN_WRAPPER[com.codename1.location.LocationManager: com.codename1.location.Location getCurrentLocationSync()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.l = -1L;
    _r0_o = ((global::com.codename1.location.LocationManager) _r2_o).getCurrentLocationSync((long) _r0.l);
    return (global::com.codename1.location.Location) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.location.LocationManager: com.codename1.location.Location getCurrentLocationSync()]
}

public virtual global::System.Object getCurrentLocationSync(long n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.location.LocationManager: com.codename1.location.Location getCurrentLocationSync(long)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r4.l = n1;
    try {
    _r2.i = ((global::com.codename1.location.LocationManager) _r3_o).getStatus();
    if (_r2.i == 0) goto label19;
    _r1_o = new global::com.codename1.location.LocationManager_2LL();
    ((global::com.codename1.location.LocationManager_2LL) _r1_o).@this((global::com.codename1.location.LocationManager) _r3_o);
    ((global::com.codename1.location.LocationManager_2LL) _r1_o)._ftimeout = _r4.l;
    ((global::com.codename1.location.LocationManager_2LL) _r1_o).bind();
    _r2_o = ((global::com.codename1.location.LocationManager_2LL) _r1_o)._fresult;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label24;
        }
        throw ex;
    } // end catch
    label18:;
    try {
    return (global::com.codename1.location.Location) _r2_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label24;
        }
        throw ex;
    } // end catch
    label19:;
    try {
    _r2_o = ((global::com.codename1.location.LocationManager) _r3_o).getCurrentLocation();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label24;
        }
        throw ex;
    } // end catch
    goto label18;
    label24:;
    _r2_o = _ex.getJavaException();
    _ex = null;
    _r0_o = _r2_o;
    ((global::java.io.IOException) _r0_o).printStackTrace();
    _r2_o = null;
    goto label18;
//XMLVM_END_WRAPPER[com.codename1.location.LocationManager: com.codename1.location.Location getCurrentLocationSync(long)]
}

public abstract global::System.Object getLastKnownLocation();

public virtual void setLocationListener(global::com.codename1.location.LocationListener n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.location.LocationManager: void setLocationListener(com.codename1.location.LocationListener)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = global::com.codename1.location.LocationManager._flistener;
    if (_r0_o == null) goto label8;
    ((global::com.codename1.location.LocationManager) _r1_o).clearListener();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label19;
        }
        throw ex;
    } // end catch
    label8:;
    try {
    global::com.codename1.location.LocationManager._flistener = (global::com.codename1.location.LocationListener) _r2_o;
    if (_r2_o != null) goto label14;
    global::System.Threading.Monitor.Exit(_r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label19;
        }
        throw ex;
    } // end catch
    label13:;
    try {
    return;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label19;
        }
        throw ex;
    } // end catch
    label14:;
    try {
    ((global::com.codename1.location.LocationManager) _r1_o).bindListener();
    global::System.Threading.Monitor.Exit(_r1_o);
    goto label13;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label19;
        }
        throw ex;
    } // end catch
    label19:;
    try {
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label19;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.location.LocationManager: void setLocationListener(com.codename1.location.LocationListener)]
}

public virtual global::System.Object getLocationListener(){
//XMLVM_BEGIN_WRAPPER[com.codename1.location.LocationManager: com.codename1.location.LocationListener getLocationListener()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = global::com.codename1.location.LocationManager._flistener;
    return (global::com.codename1.location.LocationListener) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.location.LocationManager: com.codename1.location.LocationListener getLocationListener()]
}

public abstract void bindListener();

public abstract void clearListener();

public virtual bool isGPSDetectionSupported(){
//XMLVM_BEGIN_WRAPPER[com.codename1.location.LocationManager: boolean isGPSDetectionSupported()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.location.LocationManager: boolean isGPSDetectionSupported()]
}

public virtual bool isGPSEnabled(){
//XMLVM_BEGIN_WRAPPER[com.codename1.location.LocationManager: boolean isGPSEnabled()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = new global::java.lang.RuntimeException();
    // Value=GPS Detection is not supported
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)71)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 68)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::java.lang.RuntimeException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.location.LocationManager: boolean isGPSEnabled()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.location.LocationManager]
//XMLVM_END_WRAPPER[com.codename1.location.LocationManager]

} // end of class: LocationManager

} // end of namespace: com.codename1.location
