// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.lang {
public class Throwable: global::java.lang.Object,global::java.io.Serializable {

private global::java.lang.String _fdetailMessage;

private global::java.lang.Throwable _fcause;

private global::org.xmlvm._nArrayAdapter<global::System.Object> _fstackTrace;

new public void @this(){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: void <init>()]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::java.lang.Throwable) _r0_o)._fcause = (global::java.lang.Throwable) _r0_o;
    ((global::java.lang.Throwable) _r0_o).fillInStackTrace();
    return;
//XMLVM_END_WRAPPER[java.lang.Throwable: void <init>()]
}

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Throwable) _r0_o).@this();
    ((global::java.lang.Throwable) _r0_o)._fdetailMessage = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.lang.Throwable: void <init>(java.lang.String)]
}

public void @this(global::java.lang.String n1, global::java.lang.Throwable n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: void <init>(java.lang.String, java.lang.Throwable)]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r2.i = 0;
    _r2.l = 0;
    _r2.f = 0;
    _r2.d = 0;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::java.lang.Throwable) _r0_o).@this();
    ((global::java.lang.Throwable) _r0_o)._fdetailMessage = (global::java.lang.String) _r1_o;
    ((global::java.lang.Throwable) _r0_o)._fcause = (global::java.lang.Throwable) _r2_o;
    return;
//XMLVM_END_WRAPPER[java.lang.Throwable: void <init>(java.lang.String, java.lang.Throwable)]
}

public void @this(global::java.lang.Throwable n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: void <init>(java.lang.Throwable)]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r2.i = 0;
    _r2.l = 0;
    _r2.f = 0;
    _r2.d = 0;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.lang.Throwable) _r1_o).@this();
    if (_r2_o != null) goto label11;
    _r0_o = null;
    label6:;
    ((global::java.lang.Throwable) _r1_o)._fdetailMessage = (global::java.lang.String) _r0_o;
    ((global::java.lang.Throwable) _r1_o)._fcause = (global::java.lang.Throwable) _r2_o;
    return;
    label11:;
    _r0_o = ((global::java.lang.Throwable) _r2_o).toString();
    goto label6;
//XMLVM_END_WRAPPER[java.lang.Throwable: void <init>(java.lang.Throwable)]
}

public virtual global::System.Object fillInStackTrace(){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: java.lang.Throwable fillInStackTrace()]
    return null;
//XMLVM_END_WRAPPER[java.lang.Throwable: java.lang.Throwable fillInStackTrace()]
}

public virtual global::System.Object getMessage(){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: java.lang.String getMessage()]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.lang.Throwable) _r1_o)._fdetailMessage;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Throwable: java.lang.String getMessage()]
}

public virtual global::System.Object getLocalizedMessage(){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: java.lang.String getLocalizedMessage()]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.lang.Throwable) _r1_o).getMessage();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Throwable: java.lang.String getLocalizedMessage()]
}

private global::System.Object getStackTraceImpl(){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: java.lang.StackTraceElement[] getStackTraceImpl()]
      throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[java.lang.Throwable: java.lang.StackTraceElement[] getStackTraceImpl()]
}

public virtual global::System.Object getStackTrace(){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: java.lang.StackTraceElement[] getStackTrace()]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.lang.Throwable) _r1_o).getInternalStackTrace();
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o).clone();
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o;
//XMLVM_END_WRAPPER[java.lang.Throwable: java.lang.StackTraceElement[] getStackTrace()]
}

public virtual void setStackTrace(global::org.xmlvm._nArrayAdapter<global::System.Object> n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: void setStackTrace(java.lang.StackTraceElement[])]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::org.xmlvm._nElement _r2;
    _r2.i = 0;
    _r2.l = 0;
    _r2.f = 0;
    _r2.d = 0;
    global::org.xmlvm._nElement _r3;
    _r3.i = 0;
    _r3.l = 0;
    _r3.f = 0;
    _r3.d = 0;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r4.i = 0;
    _r4.l = 0;
    _r4.f = 0;
    _r4.d = 0;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r5.i = 0;
    _r5.l = 0;
    _r5.f = 0;
    _r5.d = 0;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r5_o).clone();
    _r1.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r2.i = 0;
    label8:;
    if (_r2.i < _r1.i) goto label13;
    ((global::java.lang.Throwable) _r4_o)._fstackTrace = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    return;
    label13:;
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r2.i];
    if (_r3_o != null) goto label23;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label23:;
    _r2.i = _r2.i + 1;
    goto label8;
//XMLVM_END_WRAPPER[java.lang.Throwable: void setStackTrace(java.lang.StackTraceElement[])]
}

public virtual void printStackTrace(){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: void printStackTrace()]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = global::java.lang.System._ferr;
    ((global::java.lang.Throwable) _r1_o).printStackTrace((global::java.io.PrintStream) _r0_o);
    return;
//XMLVM_END_WRAPPER[java.lang.Throwable: void printStackTrace()]
}

private static int countDuplicates(global::org.xmlvm._nArrayAdapter<global::System.Object> n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: int countDuplicates(java.lang.StackTraceElement[], java.lang.StackTraceElement[])]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::org.xmlvm._nElement _r2;
    _r2.i = 0;
    _r2.l = 0;
    _r2.f = 0;
    _r2.d = 0;
    global::org.xmlvm._nElement _r3;
    _r3.i = 0;
    _r3.l = 0;
    _r3.f = 0;
    _r3.d = 0;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r4.i = 0;
    _r4.l = 0;
    _r4.f = 0;
    _r4.d = 0;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r5.i = 0;
    _r5.l = 0;
    _r5.f = 0;
    _r5.d = 0;
    global::org.xmlvm._nElement _r6;
    _r6.i = 0;
    _r6.l = 0;
    _r6.f = 0;
    _r6.d = 0;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    _r7.i = 0;
    _r7.l = 0;
    _r7.f = 0;
    _r7.d = 0;
    global::System.Object _r7_o = null;
    _r6_o = n1;
    _r7_o = n2;
    _r0.i = 0;
    _r1.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    _r2.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    _r5.i = _r2.i;
    _r2.i = _r0.i;
    _r0.i = _r5.i;
    label6:;
    _r0.i = _r0.i + -1;
    if (_r0.i < 0) goto label14;
    _r1.i = _r1.i + -1;
    if (_r1.i >= 0) goto label15;
    label14:;
    return _r2.i;
    label15:;
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r7_o)[_r1.i];
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r6_o)[_r0.i];
    _r3.i = ((global::java.lang.StackTraceElement) _r3_o).equals((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r3.i == 0) goto label14;
    _r2.i = _r2.i + 1;
    goto label6;
//XMLVM_END_WRAPPER[java.lang.Throwable: int countDuplicates(java.lang.StackTraceElement[], java.lang.StackTraceElement[])]
}

private global::System.Object getInternalStackTrace(){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: java.lang.StackTraceElement[] getInternalStackTrace()]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.lang.Throwable) _r1_o)._fstackTrace;
    if (_r0_o != null) goto label10;
    _r0_o = ((global::java.lang.Throwable) _r1_o).getStackTraceImpl();
    ((global::java.lang.Throwable) _r1_o)._fstackTrace = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    label10:;
    _r0_o = ((global::java.lang.Throwable) _r1_o)._fstackTrace;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Throwable: java.lang.StackTraceElement[] getInternalStackTrace()]
}

public virtual void printStackTrace(global::java.io.PrintStream n1){
    n1.println(com.codename1.impl.SilverlightImplementation.toJava("Stack traces aren't supported at the moment"));
    n1.println((java.lang.String)toString());
}

public virtual void printStackTrace(global::java.io.PrintWriter n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: void printStackTrace(java.io.PrintWriter)]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r2.i = 0;
    _r2.l = 0;
    _r2.f = 0;
    _r2.d = 0;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r3.i = 0;
    _r3.l = 0;
    _r3.f = 0;
    _r3.d = 0;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r4.i = 0;
    _r4.l = 0;
    _r4.f = 0;
    _r4.d = 0;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r5.i = 0;
    _r5.l = 0;
    _r5.f = 0;
    _r5.d = 0;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    _r6.i = 0;
    _r6.l = 0;
    _r6.f = 0;
    _r6.d = 0;
    global::org.xmlvm._nElement _r7;
    _r7.i = 0;
    _r7.l = 0;
    _r7.f = 0;
    _r7.d = 0;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    _r8.i = 0;
    _r8.l = 0;
    _r8.f = 0;
    _r8.d = 0;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    _r9.i = 0;
    _r9.l = 0;
    _r9.f = 0;
    _r9.d = 0;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    _r10.i = 0;
    _r10.l = 0;
    _r10.f = 0;
    _r10.d = 0;
    global::System.Object _r10_o = null;
    _r9_o = this;
    _r10_o = n1;
    _r6.i = 0;
    // Value=\011at 
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)9)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32))}));
    _r0_o = ((global::java.lang.Throwable) _r9_o).toString();
    ((global::java.io.PrintWriter) _r10_o).println((global::java.lang.String) _r0_o);
    _r0_o = ((global::java.lang.Throwable) _r9_o).getInternalStackTrace();
    _r1.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r2.i = _r6.i;
    label16:;
    if (_r2.i < _r1.i) goto label28;
    _r1_o = ((global::java.lang.Throwable) _r9_o).getCause();
    _r8_o = _r1_o;
    _r1_o = _r0_o;
    _r0_o = _r8_o;
    label25:;
    if (_r0_o != null) goto label51;
    return;
    label28:;
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r2.i];
    _r4_o = new global::java.lang.StringBuilder();
    // Value=\011at 
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)9)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r4_o).@this((global::java.lang.String) _r7_o);
    _r3_o = ((global::java.lang.StringBuilder) _r4_o).append((global::java.lang.Object) _r3_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    ((global::java.io.PrintWriter) _r10_o).println((global::java.lang.String) _r3_o);
    _r2.i = _r2.i + 1;
    goto label16;
    label51:;
    // Value=Caused by: 
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.io.PrintWriter) _r10_o).print((global::java.lang.String) _r2_o);
    ((global::java.io.PrintWriter) _r10_o).println((global::java.lang.Object) _r0_o);
    _r2_o = ((global::java.lang.Throwable) _r0_o).getInternalStackTrace();
    _r1.i = global::java.lang.Throwable.countDuplicates((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o);
    _r3.i = _r6.i;
    label68:;
    _r4.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    _r4.i = _r4.i - _r1.i;
    if (_r3.i < _r4.i) goto label104;
    if (_r1.i <= 0) goto label98;
    _r3_o = new global::java.lang.StringBuilder();
    // Value=\011... 
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)9)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r3_o).@this((global::java.lang.String) _r4_o);
    _r1_o = ((global::java.lang.StringBuilder) _r3_o).append((int) _r1.i);
    // Value= more
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101))}));
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r3_o);
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    ((global::java.io.PrintWriter) _r10_o).println((global::java.lang.String) _r1_o);
    label98:;
    _r0_o = ((global::java.lang.Throwable) _r0_o).getCause();
    _r1_o = _r2_o;
    goto label25;
    label104:;
    _r4_o = new global::java.lang.StringBuilder();
    // Value=\011at 
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)9)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r4_o).@this((global::java.lang.String) _r7_o);
    _r5_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r3.i];
    _r4_o = ((global::java.lang.StringBuilder) _r4_o).append((global::java.lang.Object) _r5_o);
    _r4_o = ((global::java.lang.StringBuilder) _r4_o).toString();
    ((global::java.io.PrintWriter) _r10_o).println((global::java.lang.String) _r4_o);
    _r3.i = _r3.i + 1;
    goto label68;
//XMLVM_END_WRAPPER[java.lang.Throwable: void printStackTrace(java.io.PrintWriter)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r2.i = 0;
    _r2.l = 0;
    _r2.f = 0;
    _r2.d = 0;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r3.i = 0;
    _r3.l = 0;
    _r3.f = 0;
    _r3.d = 0;
    global::org.xmlvm._nElement _r4;
    _r4.i = 0;
    _r4.l = 0;
    _r4.f = 0;
    _r4.d = 0;
    global::org.xmlvm._nElement _r5;
    _r5.i = 0;
    _r5.l = 0;
    _r5.f = 0;
    _r5.d = 0;
    global::System.Object _r5_o = null;
    _r5_o = this;
    _r0_o = ((global::java.lang.Throwable) _r5_o).getLocalizedMessage();
    _r1_o = ((global::java.lang.Object) _r5_o).getClass();
    _r1_o = ((global::java.lang.Class) _r1_o).getName();
    if (_r0_o != null) goto label16;
    _r0_o = _r1_o;
    label15:;
    return (global::java.lang.String) _r0_o;
    label16:;
    _r2_o = new global::java.lang.StringBuilder();
    _r3.i = ((global::java.lang.String) _r1_o).length();
    _r3.i = _r3.i + 2;
    _r4.i = ((global::java.lang.String) _r0_o).length();
    _r3.i = _r3.i + _r4.i;
    ((global::java.lang.StringBuilder) _r2_o).@this((int) _r3.i);
    _r1_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r1_o);
    // Value=: 
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58)), unchecked((char) unchecked((uint) 32))}));
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r2_o);
    _r0_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r0_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    goto label15;
//XMLVM_END_WRAPPER[java.lang.Throwable: java.lang.String toString()]
}

public virtual global::System.Object initCause(global::java.lang.Throwable n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: java.lang.Throwable initCause(java.lang.Throwable)]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r2.i = 0;
    _r2.l = 0;
    _r2.f = 0;
    _r2.d = 0;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r3.i = 0;
    _r3.l = 0;
    _r3.f = 0;
    _r3.d = 0;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    global::System.Threading.Monitor.Enter(_r2_o);
    try {
    _r0_o = ((global::java.lang.Throwable) _r2_o)._fcause;
    if (_r0_o != _r2_o) goto label22;
    if (_r3_o == _r2_o) goto label11;
    ((global::java.lang.Throwable) _r2_o)._fcause = (global::java.lang.Throwable) _r3_o;
    }
    catch (global::org.xmlvm._nExceptionAdapter ex) {
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label19;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r2_o);
    return (global::java.lang.Throwable) _r2_o;
    label11:;
    try {
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=Cause cannot be the receiver
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    }
    catch (global::org.xmlvm._nExceptionAdapter ex) {
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label19;
        }
        throw ex;
    } // end catch
    label19:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
    label22:;
    try {
    _r0_o = new global::java.lang.IllegalStateException();
    // Value=Cause already initialized
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 122)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::java.lang.IllegalStateException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r0_o);
    }
    catch (global::org.xmlvm._nExceptionAdapter ex) {
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label19;
        }
        throw ex;
    } // end catch
//XMLVM_END_WRAPPER[java.lang.Throwable: java.lang.Throwable initCause(java.lang.Throwable)]
}

public virtual global::System.Object getCause(){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: java.lang.Throwable getCause()]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.lang.Throwable) _r1_o)._fcause;
    if (_r0_o != _r1_o) goto label6;
    _r0_o = null;
    label5:;
    return (global::java.lang.Throwable) _r0_o;
    label6:;
    _r0_o = ((global::java.lang.Throwable) _r1_o)._fcause;
    goto label5;
//XMLVM_END_WRAPPER[java.lang.Throwable: java.lang.Throwable getCause()]
}

private void writeObject(global::java.io.ObjectOutputStream n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Throwable: void writeObject(java.io.ObjectOutputStream)]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Throwable) _r0_o).getInternalStackTrace();
    ((global::java.io.ObjectOutputStream) _r1_o).defaultWriteObject();
    return;
//XMLVM_END_WRAPPER[java.lang.Throwable: void writeObject(java.io.ObjectOutputStream)]
}

//XMLVM_BEGIN_WRAPPER[java.lang.Throwable]
//XMLVM_END_WRAPPER[java.lang.Throwable]

} // end of class: Throwable

} // end of namespace: java.lang
