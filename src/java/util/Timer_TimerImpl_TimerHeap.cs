// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Timer_2TimerImpl_2TimerHeap: global::java.lang.Object {
private int _fDEFAULT_1HEAP_1SIZE;

private global::org.xmlvm._nArrayAdapter<global::System.Object> _ftimers;

private int _fsize;

private int _fdeletedCancelledNumber;

private void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r1.i = 0;
    ((global::java.lang.Object) _r2_o).@this();
    _r0.i = 256;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r2_o)._fDEFAULT_1HEAP_1SIZE = _r0.i;
    _r0.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r2_o)._fDEFAULT_1HEAP_1SIZE;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r2_o)._ftimers = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r2_o)._fsize = _r1.i;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r2_o)._fdeletedCancelledNumber = _r1.i;
    return;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void <init>()]
}

public virtual global::System.Object minimum(){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: java.util.TimerTask minimum()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r2_o)._ftimers;
    _r1.i = 0;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    return (global::java.util.TimerTask) _r0_o;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: java.util.TimerTask minimum()]
}

public virtual bool isEmpty(){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: boolean isEmpty()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r1_o)._fsize;
    if (_r0.i != 0) goto label6;
    _r0.i = 1;
    label5:;
    return _r0.i!=0;
    label6:;
    _r0.i = 0;
    goto label5;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: boolean isEmpty()]
}

public virtual void insert(global::java.util.TimerTask n1){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void insert(java.util.TimerTask)]
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
    _r4_o = this;
    _r5_o = n1;
    _r3.i = 0;
    _r0_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._ftimers;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r1.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._fsize;
    if (_r0.i != _r1.i) goto label23;
    _r0.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._fsize;
    _r0.i = _r0.i * 2;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._ftimers;
    _r2.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._fsize;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r1_o, (int) _r3.i, (global::java.lang.Object) _r0_o, (int) _r3.i, (int) _r2.i);
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._ftimers = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    label23:;
    _r0_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._ftimers;
    _r1.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._fsize;
    _r2.i = _r1.i + 1;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._fsize = _r2.i;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r5_o;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o).upHeap();
    return;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void insert(java.util.TimerTask)]
}

public virtual void delete(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void delete(int)]
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
    _r4_o = this;
    _r5.i = n1;
    if (_r5.i < 0) goto label30;
    _r0.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._fsize;
    if (_r5.i >= _r0.i) goto label30;
    _r0_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._ftimers;
    _r1_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._ftimers;
    _r2.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._fsize;
    _r3.i = 1;
    _r2.i = _r2.i - _r3.i;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._fsize = _r2.i;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r2.i];
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r5.i] = _r1_o;
    _r0_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._ftimers;
    _r1.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o)._fsize;
    _r2_o = null;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r4_o).downHeap((int) _r5.i);
    label30:;
    return;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void delete(int)]
}

private void upHeap(){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void upHeap()]
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
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r8_o = this;
    _r6.i = 1;
    _r0.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r8_o)._fsize;
    _r0.i = _r0.i - _r6.i;
    _r1.i = _r0.i - _r6.i;
    _r1.i = _r1.i / 2;
    _r7.i = _r1.i;
    _r1.i = _r0.i;
    _r0.i = _r7.i;
    label11:;
    _r2_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r8_o)._ftimers;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r1.i];
    _r2.l = ((global::java.util.TimerTask) _r2_o)._fwhen;
    _r4_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r8_o)._ftimers;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o)[_r0.i];
    _r4.l = ((global::java.util.TimerTask) _r4_o)._fwhen;
    _r2.i = _r2.l > _r4.l ? 1 : (_r2.l == _r4.l ? 0 : -1);
    if (_r2.i < 0) goto label28;
    return;
    label28:;
    _r2_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r8_o)._ftimers;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r1.i];
    _r3_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r8_o)._ftimers;
    _r4_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r8_o)._ftimers;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o)[_r0.i];
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r1.i] = _r4_o;
    _r1_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r8_o)._ftimers;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i] = _r2_o;
    _r1.i = _r0.i - _r6.i;
    _r1.i = _r1.i / 2;
    _r7.i = _r1.i;
    _r1.i = _r0.i;
    _r0.i = _r7.i;
    goto label11;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void upHeap()]
}

private void downHeap(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void downHeap(int)]
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
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = this;
    _r8.i = n1;
    _r0.i = _r8.i * 2;
    _r0.i = _r0.i + 1;
    _r1.i = _r8.i;
    label5:;
    _r2.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r7_o)._fsize;
    if (_r0.i >= _r2.i) goto label13;
    _r2.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r7_o)._fsize;
    if (_r2.i > 0) goto label14;
    label13:;
    return;
    label14:;
    _r2.i = _r0.i + 1;
    _r3.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r7_o)._fsize;
    if (_r2.i >= _r3.i) goto label40;
    _r2_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r7_o)._ftimers;
    _r3.i = _r0.i + 1;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r3.i];
    _r2.l = ((global::java.util.TimerTask) _r2_o)._fwhen;
    _r4_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r7_o)._ftimers;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o)[_r0.i];
    _r4.l = ((global::java.util.TimerTask) _r4_o)._fwhen;
    _r2.i = _r2.l > _r4.l ? 1 : (_r2.l == _r4.l ? 0 : -1);
    if (_r2.i >= 0) goto label40;
    _r0.i = _r0.i + 1;
    label40:;
    _r2_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r7_o)._ftimers;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r1.i];
    _r2.l = ((global::java.util.TimerTask) _r2_o)._fwhen;
    _r4_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r7_o)._ftimers;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o)[_r0.i];
    _r4.l = ((global::java.util.TimerTask) _r4_o)._fwhen;
    _r2.i = _r2.l > _r4.l ? 1 : (_r2.l == _r4.l ? 0 : -1);
    if (_r2.i < 0) goto label13;
    _r2_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r7_o)._ftimers;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r1.i];
    _r3_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r7_o)._ftimers;
    _r4_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r7_o)._ftimers;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o)[_r0.i];
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r1.i] = _r4_o;
    _r1_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r7_o)._ftimers;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i] = _r2_o;
    _r1.i = _r0.i * 2;
    _r1.i = _r1.i + 1;
    _r6.i = _r1.i;
    _r1.i = _r0.i;
    _r0.i = _r6.i;
    goto label5;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void downHeap(int)]
}

public virtual void reset(){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void reset()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r1_o)._fDEFAULT_1HEAP_1SIZE;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r1_o)._ftimers = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    _r0.i = 0;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r1_o)._fsize = _r0.i;
    return;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void reset()]
}

public virtual void adjustMinimum(){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void adjustMinimum()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 0;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r1_o).downHeap((int) _r0.i);
    return;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void adjustMinimum()]
}

public virtual void deleteIfCancelled(){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void deleteIfCancelled()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.i = 0;
    label1:;
    _r1.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r2_o)._fsize;
    if (_r0.i < _r1.i) goto label6;
    return;
    label6:;
    _r1_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r2_o)._ftimers;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i];
    _r1.i = ((global::java.util.TimerTask) _r1_o)._fcancelled ? 1 : 0;
    if (_r1.i == 0) goto label25;
    _r1.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r2_o)._fdeletedCancelledNumber;
    _r1.i = _r1.i + 1;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r2_o)._fdeletedCancelledNumber = _r1.i;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r2_o).delete((int) _r0.i);
    _r0.i = _r0.i + -1;
    label25:;
    _r0.i = _r0.i + 1;
    goto label1;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void deleteIfCancelled()]
}

private int getTask(global::java.util.TimerTask n1){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: int getTask(java.util.TimerTask)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = 0;
    label1:;
    _r1_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r2_o)._ftimers;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    if (_r0.i < _r1.i) goto label8;
    _r0.i = -1;
    label7:;
    return _r0.i;
    label8:;
    _r1_o = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r2_o)._ftimers;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i];
    if (_r1_o == _r3_o) goto label7;
    _r0.i = _r0.i + 1;
    goto label1;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: int getTask(java.util.TimerTask)]
}

public void @this(global::java.util.Timer_2TimerImpl_2TimerHeap n1){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void <init>(java.util.Timer$TimerImpl$TimerHeap)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void <init>(java.util.Timer$TimerImpl$TimerHeap)]
}

public static int access_21(global::java.util.Timer_2TimerImpl_2TimerHeap n1, global::java.util.TimerTask n2){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: int access$1(java.util.Timer$TimerImpl$TimerHeap, java.util.TimerTask)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r2_o = n2;
    _r0.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r1_o).getTask((global::java.util.TimerTask) _r2_o);
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: int access$1(java.util.Timer$TimerImpl$TimerHeap, java.util.TimerTask)]
}

public static void access_22(global::java.util.Timer_2TimerImpl_2TimerHeap n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void access$2(java.util.Timer$TimerImpl$TimerHeap, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = n1;
    _r1.i = n2;
    ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r0_o)._fdeletedCancelledNumber = _r1.i;
    return;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: void access$2(java.util.Timer$TimerImpl$TimerHeap, int)]
}

public static int access_23(global::java.util.Timer_2TimerImpl_2TimerHeap n1){
//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: int access$3(java.util.Timer$TimerImpl$TimerHeap)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r0.i = ((global::java.util.Timer_2TimerImpl_2TimerHeap) _r1_o)._fdeletedCancelledNumber;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap: int access$3(java.util.Timer$TimerImpl$TimerHeap)]
}

//XMLVM_BEGIN_WRAPPER[java.util.Timer$TimerImpl$TimerHeap]
//XMLVM_END_WRAPPER[java.util.Timer$TimerImpl$TimerHeap]

} // end of class: Timer_2TimerImpl_2TimerHeap

} // end of namespace: java.util
