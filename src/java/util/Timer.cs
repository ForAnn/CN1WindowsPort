// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Timer: global::java.lang.Object {
private static long _ftimerId;

private global::java.util.Timer_2TimerImpl _fimpl;

private global::java.util.Timer_2FinalizerHelper _ffinalizer;

private static long nextId(){
//XMLVM_BEGIN_WRAPPER[java.util.Timer: long nextId()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.util.Timer));
    global::System.Threading.Monitor.Enter(_r0_o);
    try {
    _r1.l = global::java.util.Timer._ftimerId;
    _r3.l = 1L;
    _r3.l = _r3.l + _r1.l;
    global::java.util.Timer._ftimerId = _r3.l;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label12;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r0_o);
    return _r1.l;
    label12:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r0_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r1_o);
//XMLVM_END_WRAPPER[java.util.Timer: long nextId()]
}

public void @this(global::java.lang.String n1, bool n2){
//XMLVM_BEGIN_WRAPPER[java.util.Timer: void <init>(java.lang.String, boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r2_o = this;
    _r3_o = n1;
    _r4.i = n2 ? 1 : 0;
    ((global::java.lang.Object) _r2_o).@this();
    if (_r3_o != null) goto label13;
    _r0_o = new global::java.lang.NullPointerException();
    // Value=name is null
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108))}));
    ((global::java.lang.NullPointerException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label13:;
    _r0_o = new global::java.util.Timer_2TimerImpl();
    ((global::java.util.Timer_2TimerImpl) _r0_o).@this((global::java.lang.String) _r3_o, 0!=_r4.i);
    ((global::java.util.Timer) _r2_o)._fimpl = (global::java.util.Timer_2TimerImpl) _r0_o;
    _r0_o = new global::java.util.Timer_2FinalizerHelper();
    _r1_o = ((global::java.util.Timer) _r2_o)._fimpl;
    ((global::java.util.Timer_2FinalizerHelper) _r0_o).@this((global::java.util.Timer_2TimerImpl) _r1_o);
    ((global::java.util.Timer) _r2_o)._ffinalizer = (global::java.util.Timer_2FinalizerHelper) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.util.Timer: void <init>(java.lang.String, boolean)]
}

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.util.Timer: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 0;
    ((global::java.util.Timer) _r1_o).@this((global::java.lang.String) _r2_o, 0!=_r0.i);
    return;
//XMLVM_END_WRAPPER[java.util.Timer: void <init>(java.lang.String)]
}

public void @this(bool n1){
//XMLVM_BEGIN_WRAPPER[java.util.Timer: void <init>(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1 ? 1 : 0;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=Timer-
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)84)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 45))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r1.l = global::java.util.Timer.nextId();
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((long) _r1.l);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    ((global::java.util.Timer) _r3_o).@this((global::java.lang.String) _r0_o, 0!=_r4.i);
    return;
//XMLVM_END_WRAPPER[java.util.Timer: void <init>(boolean)]
}

public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.Timer: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    ((global::java.util.Timer) _r1_o).@this(0!=_r0.i);
    return;
//XMLVM_END_WRAPPER[java.util.Timer: void <init>()]
}

public virtual void cancel(){
//XMLVM_BEGIN_WRAPPER[java.util.Timer: void cancel()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Timer) _r1_o)._fimpl;
    ((global::java.util.Timer_2TimerImpl) _r0_o).cancel();
    return;
//XMLVM_END_WRAPPER[java.util.Timer: void cancel()]
}

public virtual int purge(){
//XMLVM_BEGIN_WRAPPER[java.util.Timer: int purge()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.util.Timer) _r2_o)._fimpl;
    global::System.Threading.Monitor.Enter(_r0_o);
    try {
    _r1_o = ((global::java.util.Timer) _r2_o)._fimpl;
    _r1.i = ((global::java.util.Timer_2TimerImpl) _r1_o).purge();
    global::System.Threading.Monitor.Exit(_r0_o);
    return _r1.i;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label11;
        }
        throw ex;
    } // end catch
    label11:;
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
            goto label11;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r1_o);
//XMLVM_END_WRAPPER[java.util.Timer: int purge()]
}

public virtual void schedule(global::java.util.TimerTask n1, global::java.util.Date n2){
//XMLVM_BEGIN_WRAPPER[java.util.Timer: void schedule(java.util.TimerTask, java.util.Date)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    _r7_o = this;
    _r8_o = n1;
    _r9_o = n2;
    _r4.l = 0L;
    _r0.l = ((global::java.util.Date) _r9_o).getTime();
    _r0.i = _r0.l > _r4.l ? 1 : (_r0.l == _r4.l ? 0 : -1);
    if (_r0.i >= 0) goto label16;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label16:;
    _r0.l = ((global::java.util.Date) _r9_o).getTime();
    _r2.l = global::java.lang.System.currentTimeMillis();
    _r0.l = _r0.l - _r2.l;
    _r2.i = _r0.l > _r4.l ? 1 : (_r0.l == _r4.l ? 0 : -1);
    if (_r2.i >= 0) goto label39;
    _r2.l = _r4.l;
    label30:;
    _r4.l = -1L;
    _r6.i = 0;
    _r0_o = _r7_o;
    _r1_o = _r8_o;
    ((global::java.util.Timer) _r0_o).scheduleImpl((global::java.util.TimerTask) _r1_o, (long) _r2.l, (long) _r4.l, 0!=_r6.i);
    return;
    label39:;
    _r2.l = _r0.l;
    goto label30;
//XMLVM_END_WRAPPER[java.util.Timer: void schedule(java.util.TimerTask, java.util.Date)]
}

public virtual void schedule(global::java.util.TimerTask n1, long n2){
//XMLVM_BEGIN_WRAPPER[java.util.Timer: void schedule(java.util.TimerTask, long)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    _r7_o = this;
    _r8_o = n1;
    _r9.l = n2;
    _r0.l = 0L;
    _r0.i = _r9.l > _r0.l ? 1 : (_r9.l == _r0.l ? 0 : -1);
    if (_r0.i >= 0) goto label12;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label12:;
    _r4.l = -1L;
    _r6.i = 0;
    _r0_o = _r7_o;
    _r1_o = _r8_o;
    _r2.l = _r9.l;
    ((global::java.util.Timer) _r0_o).scheduleImpl((global::java.util.TimerTask) _r1_o, (long) _r2.l, (long) _r4.l, 0!=_r6.i);
    return;
//XMLVM_END_WRAPPER[java.util.Timer: void schedule(java.util.TimerTask, long)]
}

public virtual void schedule(global::java.util.TimerTask n1, long n2, long n3){
//XMLVM_BEGIN_WRAPPER[java.util.Timer: void schedule(java.util.TimerTask, long, long)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r11;
    _r7_o = this;
    _r8_o = n1;
    _r9.l = n2;
    _r11.l = n3;
    _r1.l = 0L;
    _r0.i = _r9.l > _r1.l ? 1 : (_r9.l == _r1.l ? 0 : -1);
    if (_r0.i < 0) goto label10;
    _r0.i = _r11.l > _r1.l ? 1 : (_r11.l == _r1.l ? 0 : -1);
    if (_r0.i > 0) goto label16;
    label10:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label16:;
    _r6.i = 0;
    _r0_o = _r7_o;
    _r1_o = _r8_o;
    _r2.l = _r9.l;
    _r4.l = _r11.l;
    ((global::java.util.Timer) _r0_o).scheduleImpl((global::java.util.TimerTask) _r1_o, (long) _r2.l, (long) _r4.l, 0!=_r6.i);
    return;
//XMLVM_END_WRAPPER[java.util.Timer: void schedule(java.util.TimerTask, long, long)]
}

public virtual void schedule(global::java.util.TimerTask n1, global::java.util.Date n2, long n3){
//XMLVM_BEGIN_WRAPPER[java.util.Timer: void schedule(java.util.TimerTask, java.util.Date, long)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    _r7_o = this;
    _r8_o = n1;
    _r9_o = n2;
    _r10.l = n3;
    _r4.l = 0L;
    _r0.i = _r10.l > _r4.l ? 1 : (_r10.l == _r4.l ? 0 : -1);
    if (_r0.i <= 0) goto label14;
    _r0.l = ((global::java.util.Date) _r9_o).getTime();
    _r0.i = _r0.l > _r4.l ? 1 : (_r0.l == _r4.l ? 0 : -1);
    if (_r0.i >= 0) goto label20;
    label14:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label20:;
    _r0.l = ((global::java.util.Date) _r9_o).getTime();
    _r2.l = global::java.lang.System.currentTimeMillis();
    _r0.l = _r0.l - _r2.l;
    _r2.i = _r0.l > _r4.l ? 1 : (_r0.l == _r4.l ? 0 : -1);
    if (_r2.i >= 0) goto label42;
    _r2.l = _r4.l;
    label34:;
    _r6.i = 0;
    _r0_o = _r7_o;
    _r1_o = _r8_o;
    _r4.l = _r10.l;
    ((global::java.util.Timer) _r0_o).scheduleImpl((global::java.util.TimerTask) _r1_o, (long) _r2.l, (long) _r4.l, 0!=_r6.i);
    return;
    label42:;
    _r2.l = _r0.l;
    goto label34;
//XMLVM_END_WRAPPER[java.util.Timer: void schedule(java.util.TimerTask, java.util.Date, long)]
}

public virtual void scheduleAtFixedRate(global::java.util.TimerTask n1, long n2, long n3){
//XMLVM_BEGIN_WRAPPER[java.util.Timer: void scheduleAtFixedRate(java.util.TimerTask, long, long)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r11;
    _r7_o = this;
    _r8_o = n1;
    _r9.l = n2;
    _r11.l = n3;
    _r1.l = 0L;
    _r0.i = _r9.l > _r1.l ? 1 : (_r9.l == _r1.l ? 0 : -1);
    if (_r0.i < 0) goto label10;
    _r0.i = _r11.l > _r1.l ? 1 : (_r11.l == _r1.l ? 0 : -1);
    if (_r0.i > 0) goto label16;
    label10:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label16:;
    _r6.i = 1;
    _r0_o = _r7_o;
    _r1_o = _r8_o;
    _r2.l = _r9.l;
    _r4.l = _r11.l;
    ((global::java.util.Timer) _r0_o).scheduleImpl((global::java.util.TimerTask) _r1_o, (long) _r2.l, (long) _r4.l, 0!=_r6.i);
    return;
//XMLVM_END_WRAPPER[java.util.Timer: void scheduleAtFixedRate(java.util.TimerTask, long, long)]
}

public virtual void scheduleAtFixedRate(global::java.util.TimerTask n1, global::java.util.Date n2, long n3){
//XMLVM_BEGIN_WRAPPER[java.util.Timer: void scheduleAtFixedRate(java.util.TimerTask, java.util.Date, long)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    _r7_o = this;
    _r8_o = n1;
    _r9_o = n2;
    _r10.l = n3;
    _r2.l = 0L;
    _r0.i = _r10.l > _r2.l ? 1 : (_r10.l == _r2.l ? 0 : -1);
    if (_r0.i <= 0) goto label14;
    _r0.l = ((global::java.util.Date) _r9_o).getTime();
    _r0.i = _r0.l > _r2.l ? 1 : (_r0.l == _r2.l ? 0 : -1);
    if (_r0.i >= 0) goto label20;
    label14:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label20:;
    _r0.l = ((global::java.util.Date) _r9_o).getTime();
    _r2.l = global::java.lang.System.currentTimeMillis();
    _r2.l = _r0.l - _r2.l;
    _r6.i = 1;
    _r0_o = _r7_o;
    _r1_o = _r8_o;
    _r4.l = _r10.l;
    ((global::java.util.Timer) _r0_o).scheduleImpl((global::java.util.TimerTask) _r1_o, (long) _r2.l, (long) _r4.l, 0!=_r6.i);
    return;
//XMLVM_END_WRAPPER[java.util.Timer: void scheduleAtFixedRate(java.util.TimerTask, java.util.Date, long)]
}

private void scheduleImpl(global::java.util.TimerTask n1, long n2, long n3, bool n4){
//XMLVM_BEGIN_WRAPPER[java.util.Timer: void scheduleImpl(java.util.TimerTask, long, long, boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = this;
    _r6_o = n1;
    _r7.l = n2;
    _r9.l = n3;
    _r11.i = n4 ? 1 : 0;
    _r0_o = ((global::java.util.Timer) _r5_o)._fimpl;
    global::System.Threading.Monitor.Enter(_r0_o);
    try {
    _r1_o = ((global::java.util.Timer) _r5_o)._fimpl;
    _r1.i = global::java.util.Timer_2TimerImpl.access_21((global::java.util.Timer_2TimerImpl) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label26;
    _r1_o = new global::java.lang.IllegalStateException();
    // Value=luni.41
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 52)), unchecked((char) unchecked((uint) 49))}));
    _r2_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r2_o);
    ((global::java.lang.IllegalStateException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label23;
        }
        throw ex;
    } // end catch
    label23:;
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
            goto label23;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r1_o);
    label26:;
    try {
    _r1.l = global::java.lang.System.currentTimeMillis();
    _r1.l = _r1.l + _r7.l;
    _r3.l = 0L;
    _r3.i = _r1.l > _r3.l ? 1 : (_r1.l == _r3.l ? 0 : -1);
    if (_r3.i >= 0) goto label49;
    _r1_o = new global::java.lang.IllegalArgumentException();
    // Value=luni.42
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 52)), unchecked((char) unchecked((uint) 50))}));
    _r2_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r2_o);
    ((global::java.lang.IllegalArgumentException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label23;
        }
        throw ex;
    } // end catch
    label49:;
    try {
    _r3_o = ((global::java.util.TimerTask) _r6_o)._flock;
    global::System.Threading.Monitor.Enter(_r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label23;
        }
        throw ex;
    } // end catch
    try {
    _r4.i = ((global::java.util.TimerTask) _r6_o).isScheduled() ? 1 : 0;
    if (_r4.i == 0) goto label73;
    _r1_o = new global::java.lang.IllegalStateException();
    // Value=luni.43
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 52)), unchecked((char) unchecked((uint) 51))}));
    _r2_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r2_o);
    ((global::java.lang.IllegalStateException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label70;
        }
        throw ex;
    } // end catch
    label70:;
    try {
    _r1_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label70;
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
            goto label23;
        }
        throw ex;
    } // end catch
    label73:;
    try {
    _r4.i = ((global::java.util.TimerTask) _r6_o)._fcancelled ? 1 : 0;
    if (_r4.i == 0) goto label89;
    _r1_o = new global::java.lang.IllegalStateException();
    // Value=luni.44
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 52)), unchecked((char) unchecked((uint) 52))}));
    _r2_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r2_o);
    ((global::java.lang.IllegalStateException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label70;
        }
        throw ex;
    } // end catch
    label89:;
    try {
    ((global::java.util.TimerTask) _r6_o)._fwhen = _r1.l;
    ((global::java.util.TimerTask) _r6_o)._fperiod = _r9.l;
    ((global::java.util.TimerTask) _r6_o)._ffixedRate = 0!=_r11.i;
    global::System.Threading.Monitor.Exit(_r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label70;
        }
        throw ex;
    } // end catch
    try {
    _r1_o = ((global::java.util.Timer) _r5_o)._fimpl;
    global::java.util.Timer_2TimerImpl.access_22((global::java.util.Timer_2TimerImpl) _r1_o, (global::java.util.TimerTask) _r6_o);
    global::System.Threading.Monitor.Exit(_r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label23;
        }
        throw ex;
    } // end catch
    return;
//XMLVM_END_WRAPPER[java.util.Timer: void scheduleImpl(java.util.TimerTask, long, long, boolean)]
}

//XMLVM_BEGIN_WRAPPER[java.util.Timer]
//XMLVM_END_WRAPPER[java.util.Timer]

} // end of class: Timer

} // end of namespace: java.util
