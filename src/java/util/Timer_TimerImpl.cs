// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Timer_2TimerImpl: global::java.lang.Thread {
private bool _fcancelled;

private bool _ffinished;

private global::java.util.Timer_2TimerImpl_2TimerHeap _ftasks;

public void @this(global::java.lang.String n1, bool n2){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl: void <init>(java.lang.String, boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r2_o = this;
    _r3_o = n1;
    _r4.i = n2 ? 1 : 0;
    ((global::java.lang.Thread) _r2_o).@this();
    _r0_o = new global::java.util.Timer_2TimerImpl_2TimerHeap();
    _r1_o = null;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r0_o).@this((global::java.util.Timer_2TimerImpl_2TimerHeap) _r1_o);
    ((global::java.util.Timer_2TimerImpl) _r2_o)._ftasks = (global::java.util.Timer_2TimerImpl_2TimerHeap) _r0_o;
    ((global::java.util.Timer_2TimerImpl) _r2_o).setName((global::java.lang.String) _r3_o);
    ((global::java.util.Timer_2TimerImpl) _r2_o).setDaemon(0!=_r4.i);
    ((global::java.util.Timer_2TimerImpl) _r2_o).start();
    return;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl: void <init>(java.lang.String, boolean)]
}

public override void run(){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl: void run()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r11_o = this;
    _r9.l = 0L;
    _r8.i = 1;
    _r7.i = 0;
    label4:;
    global::System.Threading.Monitor.Enter(_r11_o);
    try {
    _r0.i = ((global::java.util.Timer_2TimerImpl) _r11_o)._fcancelled ? 1 : 0;
    if (_r0.i == 0) goto label11;
    global::System.Threading.Monitor.Exit(_r11_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    label10:;
    try {
    return;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    label11:;
    try {
    _r0_o = ((global::java.util.Timer_2TimerImpl) _r11_o)._ftasks;
    _r0.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r0_o).isEmpty() ? 1 : 0;
    if (_r0.i == 0) goto label33;
    _r0.i = ((global::java.util.Timer_2TimerImpl) _r11_o)._ffinished ? 1 : 0;
    if (_r0.i == 0) goto label28;
    global::System.Threading.Monitor.Exit(_r11_o);
    goto label10;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    label25:;
    try {
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r11_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
    label28:;
    try {
    ((global::java.lang.Object) _r11_o).wait();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.InterruptedException) {
            _ex = ex;
            goto label194;
        }
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    label31:;
    try {
    global::System.Threading.Monitor.Exit(_r11_o);
    goto label4;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    label33:;
    try {
    _r0.l = global::java.lang.System.currentTimeMillis();
    _r2_o = ((global::java.util.Timer_2TimerImpl) _r11_o)._ftasks;
    _r2_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r2_o).minimum();
    _r3_o = ((global::java.util.TimerTask) _r2_o)._flock;
    global::System.Threading.Monitor.Enter(_r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    try {
    _r4.i = ((global::java.util.TimerTask) _r2_o)._fcancelled ? 1 : 0;
    if (_r4.i == 0) goto label59;
    _r0_o = ((global::java.util.Timer_2TimerImpl) _r11_o)._ftasks;
    _r1.i = 0;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r0_o).delete((int) _r1.i);
    global::System.Threading.Monitor.Exit(_r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label73;
        }
        throw ex;
    } // end catch
    try {
    global::System.Threading.Monitor.Exit(_r11_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    goto label4;
    label59:;
    try {
    _r4.l = ((global::java.util.TimerTask) _r2_o)._fwhen;
    _r0.l = _r4.l - _r0.l;
    global::System.Threading.Monitor.Exit(_r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label73;
        }
        throw ex;
    } // end catch
    _r3.i = _r0.l > _r9.l ? 1 : (_r0.l == _r9.l ? 0 : -1);
    if (_r3.i <= 0) goto label76;
    try {
    ((global::java.lang.Object) _r11_o).wait((long) _r0.l);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.InterruptedException) {
            _ex = ex;
            goto label197;
        }
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    label71:;
    try {
    global::System.Threading.Monitor.Exit(_r11_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    goto label4;
    label73:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    try {
    global::System.Threading.Monitor.Exit(_r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label73;
        }
        throw ex;
    } // end catch
    try {
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    label76:;
    try {
    _r0_o = ((global::java.util.TimerTask) _r2_o)._flock;
    global::System.Threading.Monitor.Enter(_r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    try {
    _r1_o = ((global::java.util.Timer_2TimerImpl) _r11_o)._ftasks;
    _r1_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r1_o).minimum();
    _r3.l = ((global::java.util.TimerTask) _r1_o)._fwhen;
    _r5.l = ((global::java.util.TimerTask) _r2_o)._fwhen;
    _r1.i = _r3.l > _r5.l ? 1 : (_r3.l == _r5.l ? 0 : -1);
    if (_r1.i == 0) goto label199;
    _r1_o = ((global::java.util.Timer_2TimerImpl) _r11_o)._ftasks;
    _r1.i = global::java.util.Timer_2TimerImpl_2TimerHeap.access_21((global::java.util.Timer_2TimerImpl_2TimerHeap) _r1_o, (global::java.util.TimerTask) _r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label174;
        }
        throw ex;
    } // end catch
    label99:;
    try {
    _r3.i = ((global::java.util.TimerTask) _r2_o)._fcancelled ? 1 : 0;
    if (_r3.i == 0) goto label117;
    _r1_o = ((global::java.util.Timer_2TimerImpl) _r11_o)._ftasks;
    _r3_o = ((global::java.util.Timer_2TimerImpl) _r11_o)._ftasks;
    _r2.i = global::java.util.Timer_2TimerImpl_2TimerHeap.access_21((global::java.util.Timer_2TimerImpl_2TimerHeap) _r3_o, (global::java.util.TimerTask) _r2_o);
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r1_o).delete((int) _r2.i);
    global::System.Threading.Monitor.Exit(_r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label174;
        }
        throw ex;
    } // end catch
    try {
    global::System.Threading.Monitor.Exit(_r11_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    goto label4;
    label117:;
    try {
    _r3.l = ((global::java.util.TimerTask) _r2_o)._fwhen;
    ((global::java.util.TimerTask) _r2_o).setScheduledTime((long) _r3.l);
    _r3_o = ((global::java.util.Timer_2TimerImpl) _r11_o)._ftasks;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r3_o).delete((int) _r1.i);
    _r3.l = ((global::java.util.TimerTask) _r2_o)._fperiod;
    _r1.i = _r3.l > _r9.l ? 1 : (_r3.l == _r9.l ? 0 : -1);
    if (_r1.i < 0) goto label177;
    _r1.i = ((global::java.util.TimerTask) _r2_o)._ffixedRate ? 1 : 0;
    if (_r1.i == 0) goto label164;
    _r3.l = ((global::java.util.TimerTask) _r2_o)._fwhen;
    _r5.l = ((global::java.util.TimerTask) _r2_o)._fperiod;
    _r3.l = _r3.l + _r5.l;
    ((global::java.util.TimerTask) _r2_o)._fwhen = _r3.l;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label174;
        }
        throw ex;
    } // end catch
    label144:;
    try {
    ((global::java.util.Timer_2TimerImpl) _r11_o).insertTask((global::java.util.TimerTask) _r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label174;
        }
        throw ex;
    } // end catch
    label147:;
    try {
    global::System.Threading.Monitor.Exit(_r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label174;
        }
        throw ex;
    } // end catch
    try {
    global::System.Threading.Monitor.Exit(_r11_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    try {
    ((global::java.util.TimerTask) _r2_o).run();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label182;
        }
        throw ex;
    } // end catch
    if (_r8.i != 0) goto label4;
    global::System.Threading.Monitor.Enter(_r11_o);
    _r0.i = 1;
    try {
    ((global::java.util.Timer_2TimerImpl) _r11_o)._fcancelled = 0!=_r0.i;
    global::System.Threading.Monitor.Exit(_r11_o);
    goto label4;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label161;
        }
        throw ex;
    } // end catch
    label161:;
    try {
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r11_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label161;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
    label164:;
    try {
    _r3.l = global::java.lang.System.currentTimeMillis();
    _r5.l = ((global::java.util.TimerTask) _r2_o)._fperiod;
    _r3.l = _r3.l + _r5.l;
    ((global::java.util.TimerTask) _r2_o)._fwhen = _r3.l;
    goto label144;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label174;
        }
        throw ex;
    } // end catch
    label174:;
    try {
    _r1_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label174;
        }
        throw ex;
    } // end catch
    try {
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    label177:;
    _r3.l = 0L;
    try {
    ((global::java.util.TimerTask) _r2_o)._fwhen = _r3.l;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label174;
        }
        throw ex;
    } // end catch
    goto label147;
    label182:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    if (_r7.i != 0) goto label190;
    global::System.Threading.Monitor.Enter(_r11_o);
    _r1.i = 1;
    try {
    ((global::java.util.Timer_2TimerImpl) _r11_o)._fcancelled = 0!=_r1.i;
    global::System.Threading.Monitor.Exit(_r11_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label191;
        }
        throw ex;
    } // end catch
    label190:;
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
    label191:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    try {
    global::System.Threading.Monitor.Exit(_r11_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label191;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
    label194:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    goto label31;
    label197:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    goto label71;
    label199:;
    _r1.i = _r7.i;
    goto label99;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl: void run()]
}

private void insertTask(global::java.util.TimerTask n1){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl: void insertTask(java.util.TimerTask)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Timer_2TimerImpl) _r1_o)._ftasks;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r0_o).insert((global::java.util.TimerTask) _r2_o);
    ((global::java.lang.Object) _r1_o).notify();
    return;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl: void insertTask(java.util.TimerTask)]
}

public virtual void cancel(){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl: void cancel()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    global::System.Threading.Monitor.Enter(_r1_o);
    _r0.i = 1;
    try {
    ((global::java.util.Timer_2TimerImpl) _r1_o)._fcancelled = 0!=_r0.i;
    _r0_o = ((global::java.util.Timer_2TimerImpl) _r1_o)._ftasks;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r0_o).reset();
    ((global::java.lang.Object) _r1_o).notify();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label14;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r1_o);
    return;
    label14:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl: void cancel()]
}

public virtual int purge(){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl: int purge()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1.i = 0;
    _r0_o = ((global::java.util.Timer_2TimerImpl) _r2_o)._ftasks;
    _r0.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r0_o).isEmpty() ? 1 : 0;
    if (_r0.i == 0) goto label11;
    _r0.i = _r1.i;
    label10:;
    return _r0.i;
    label11:;
    _r0_o = ((global::java.util.Timer_2TimerImpl) _r2_o)._ftasks;
    global::java.util.Timer_2TimerImpl_2TimerHeap.access_22((global::java.util.Timer_2TimerImpl_2TimerHeap) _r0_o, (int) _r1.i);
    _r0_o = ((global::java.util.Timer_2TimerImpl) _r2_o)._ftasks;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r0_o).deleteIfCancelled();
    _r0_o = ((global::java.util.Timer_2TimerImpl) _r2_o)._ftasks;
    _r0.i = global::java.util.Timer_2TimerImpl_2TimerHeap.access_23((global::java.util.Timer_2TimerImpl_2TimerHeap) _r0_o);
    goto label10;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl: int purge()]
}

public static void access_20(global::java.util.Timer_2TimerImpl n1, bool n2){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl: void access$0(java.util.Timer$TimerImpl, boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = n1;
    _r1.i = n2 ? 1 : 0;
    ((global::java.util.Timer_2TimerImpl) _r0_o)._ffinished = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl: void access$0(java.util.Timer$TimerImpl, boolean)]
}

public static bool access_21(global::java.util.Timer_2TimerImpl n1){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl: boolean access$1(java.util.Timer$TimerImpl)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0.i = ((global::java.util.Timer_2TimerImpl) _r1_o)._fcancelled ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl: boolean access$1(java.util.Timer$TimerImpl)]
}

public static void access_22(global::java.util.Timer_2TimerImpl n1, global::java.util.TimerTask n2){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl: void access$2(java.util.Timer$TimerImpl, java.util.TimerTask)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = n1;
    _r1_o = n2;
    ((global::java.util.Timer_2TimerImpl) _r0_o).insertTask((global::java.util.TimerTask) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl: void access$2(java.util.Timer$TimerImpl, java.util.TimerTask)]
}

//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl]
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl]

} // end of class: Timer_2TimerImpl

} // end of namespace: java.util
