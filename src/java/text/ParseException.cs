// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.text {
public class ParseException: global::java.lang.Exception {
private int _ferrorOffset;

private global::java.lang.Throwable _fcausedBy;

public void @this(global::java.lang.String n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.text.ParseException: void <init>(java.lang.String, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2;
    ((global::java.lang.Exception) _r0_o).@this((global::java.lang.String) _r1_o);
    ((global::java.text.ParseException) _r0_o)._ferrorOffset = _r2.i;
    return;
//XMLVM_END_WRAPPER[java.text.ParseException: void <init>(java.lang.String, int)]
}

public void @this(global::java.lang.Throwable n1, global::java.lang.String n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.text.ParseException: void <init>(java.lang.Throwable, java.lang.String, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.i = n3;
    if (_r3_o != null) goto label16;
    if (_r2_o == null) goto label16;
    _r0_o = ((global::java.lang.Throwable) _r2_o).getMessage();
    label8:;
    ((global::java.lang.Exception) _r1_o).@this((global::java.lang.String) _r0_o);
    ((global::java.text.ParseException) _r1_o)._fcausedBy = (global::java.lang.Throwable) _r2_o;
    ((global::java.text.ParseException) _r1_o)._ferrorOffset = _r4.i;
    return;
    label16:;
    _r0_o = _r3_o;
    goto label8;
//XMLVM_END_WRAPPER[java.text.ParseException: void <init>(java.lang.Throwable, java.lang.String, int)]
}

public virtual int getErrorOffset(){
//XMLVM_BEGIN_WRAPPER[java.text.ParseException: int getErrorOffset()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.text.ParseException) _r1_o)._ferrorOffset;
    return _r0.i;
//XMLVM_END_WRAPPER[java.text.ParseException: int getErrorOffset()]
}

public virtual global::System.Object getCausedBy(){
//XMLVM_BEGIN_WRAPPER[java.text.ParseException: java.lang.Throwable getCausedBy()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.text.ParseException) _r1_o)._fcausedBy;
    return (global::java.lang.Throwable) _r0_o;
//XMLVM_END_WRAPPER[java.text.ParseException: java.lang.Throwable getCausedBy()]
}

//XMLVM_BEGIN_WRAPPER[java.text.ParseException]
//XMLVM_END_WRAPPER[java.text.ParseException]

} // end of class: ParseException

} // end of namespace: java.text
