// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.lang {
public class StackTraceElement: global::java.lang.Object,global::java.io.Serializable {
private static long _fserialVersionUID = 6992337162326171013L;

public global::java.lang.String _fdeclaringClass;

public global::java.lang.String _fmethodName;

public global::java.lang.String _ffileName;

public int _flineNumber;

public void @this(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3, int n4){
//XMLVM_BEGIN_WRAPPER[java.lang.StackTraceElement: void <init>(java.lang.String, java.lang.String, java.lang.String, int)]
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
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r5.i = n4;
    ((global::java.lang.Object) _r1_o).@this();
    if (_r2_o == null) goto label7;
    if (_r3_o != null) goto label13;
    label7:;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label13:;
    ((global::java.lang.StackTraceElement) _r1_o)._fdeclaringClass = (global::java.lang.String) _r2_o;
    ((global::java.lang.StackTraceElement) _r1_o)._fmethodName = (global::java.lang.String) _r3_o;
    ((global::java.lang.StackTraceElement) _r1_o)._ffileName = (global::java.lang.String) _r4_o;
    ((global::java.lang.StackTraceElement) _r1_o)._flineNumber = _r5.i;
    return;
//XMLVM_END_WRAPPER[java.lang.StackTraceElement: void <init>(java.lang.String, java.lang.String, java.lang.String, int)]
}

private void @this(){
//XMLVM_BEGIN_WRAPPER[java.lang.StackTraceElement: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.lang.StackTraceElement: void <init>()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.lang.StackTraceElement: boolean equals(java.lang.Object)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r4_o = n1;
    _r2.i = 0;
    _r0.i = ((_r4_o != null) && (_r4_o is global::java.lang.StackTraceElement)) ? 1 : 0;
    if (_r0.i != 0) goto label7;
    _r0.i = _r2.i;
    label6:;
    return _r0.i!=0;
    label7:;
    _r4_o = _r4_o;
    _r0_o = ((global::java.lang.StackTraceElement) _r3_o)._fmethodName;
    if (_r0_o == null) goto label17;
    _r0_o = ((global::java.lang.StackTraceElement) _r4_o)._fmethodName;
    if (_r0_o != null) goto label19;
    label17:;
    _r0.i = _r2.i;
    goto label6;
    label19:;
    _r0_o = ((global::java.lang.StackTraceElement) _r3_o).getMethodName();
    _r1_o = ((global::java.lang.StackTraceElement) _r4_o).getMethodName();
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label35;
    _r0.i = _r2.i;
    goto label6;
    label35:;
    _r0_o = ((global::java.lang.StackTraceElement) _r3_o).getClassName();
    _r1_o = ((global::java.lang.StackTraceElement) _r4_o).getClassName();
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label51;
    _r0.i = _r2.i;
    goto label6;
    label51:;
    _r0_o = ((global::java.lang.StackTraceElement) _r3_o).getFileName();
    if (_r0_o != null) goto label65;
    _r0_o = ((global::java.lang.StackTraceElement) _r4_o).getFileName();
    if (_r0_o == null) goto label77;
    _r0.i = _r2.i;
    goto label6;
    label65:;
    _r1_o = ((global::java.lang.StackTraceElement) _r4_o).getFileName();
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label77;
    _r0.i = _r2.i;
    goto label6;
    label77:;
    _r0.i = ((global::java.lang.StackTraceElement) _r3_o).getLineNumber();
    _r1.i = ((global::java.lang.StackTraceElement) _r4_o).getLineNumber();
    if (_r0.i == _r1.i) goto label89;
    _r0.i = _r2.i;
    goto label6;
    label89:;
    _r0.i = 1;
    goto label6;
//XMLVM_END_WRAPPER[java.lang.StackTraceElement: boolean equals(java.lang.Object)]
}

public virtual global::System.Object getClassName(){
//XMLVM_BEGIN_WRAPPER[java.lang.StackTraceElement: java.lang.String getClassName()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.lang.StackTraceElement) _r1_o)._fdeclaringClass;
    if (_r0_o != null) goto label7;
    // Value=<unknown class>
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)60)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 62))}));
    label6:;
    return (global::java.lang.String) _r0_o;
    label7:;
    _r0_o = ((global::java.lang.StackTraceElement) _r1_o)._fdeclaringClass;
    goto label6;
//XMLVM_END_WRAPPER[java.lang.StackTraceElement: java.lang.String getClassName()]
}

public virtual global::System.Object getFileName(){
//XMLVM_BEGIN_WRAPPER[java.lang.StackTraceElement: java.lang.String getFileName()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.lang.StackTraceElement) _r1_o)._ffileName;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.lang.StackTraceElement: java.lang.String getFileName()]
}

public virtual int getLineNumber(){
//XMLVM_BEGIN_WRAPPER[java.lang.StackTraceElement: int getLineNumber()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::java.lang.StackTraceElement) _r1_o)._flineNumber;
    return _r0.i;
//XMLVM_END_WRAPPER[java.lang.StackTraceElement: int getLineNumber()]
}

public virtual global::System.Object getMethodName(){
//XMLVM_BEGIN_WRAPPER[java.lang.StackTraceElement: java.lang.String getMethodName()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.lang.StackTraceElement) _r1_o)._fmethodName;
    if (_r0_o != null) goto label7;
    // Value=<unknown method>
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)60)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 62))}));
    label6:;
    return (global::java.lang.String) _r0_o;
    label7:;
    _r0_o = ((global::java.lang.StackTraceElement) _r1_o)._fmethodName;
    goto label6;
//XMLVM_END_WRAPPER[java.lang.StackTraceElement: java.lang.String getMethodName()]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.lang.StackTraceElement: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.lang.StackTraceElement) _r2_o)._fmethodName;
    if (_r0_o != null) goto label6;
    _r0.i = 0;
    label5:;
    return _r0.i;
    label6:;
    _r0_o = ((global::java.lang.StackTraceElement) _r2_o)._fmethodName;
    _r0.i = ((global::java.lang.String) _r0_o).hashCode();
    _r1_o = ((global::java.lang.StackTraceElement) _r2_o)._fdeclaringClass;
    _r1.i = ((global::java.lang.String) _r1_o).hashCode();
    _r0.i = _r0.i ^ _r1.i;
    goto label5;
//XMLVM_END_WRAPPER[java.lang.StackTraceElement: int hashCode()]
}

public virtual bool isNativeMethod(){
//XMLVM_BEGIN_WRAPPER[java.lang.StackTraceElement: boolean isNativeMethod()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.i = ((global::java.lang.StackTraceElement) _r2_o)._flineNumber;
    _r1.i = -2;
    if (_r0.i != _r1.i) goto label7;
    _r0.i = 1;
    label6:;
    return _r0.i!=0;
    label7:;
    _r0.i = 0;
    goto label6;
//XMLVM_END_WRAPPER[java.lang.StackTraceElement: boolean isNativeMethod()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[java.lang.StackTraceElement: java.lang.String toString()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    _r1.i = 80;
    ((global::java.lang.StringBuilder) _r0_o).@this((int) _r1.i);
    _r1_o = ((global::java.lang.StackTraceElement) _r4_o).getClassName();
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = 46;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    _r1_o = ((global::java.lang.StackTraceElement) _r4_o).getMethodName();
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::java.lang.StackTraceElement) _r4_o).isNativeMethod() ? 1 : 0;
    if (_r1.i == 0) goto label42;
    // Value=(Native Method)
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)40)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 41))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    label37:;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
    label42:;
    _r1_o = ((global::java.lang.StackTraceElement) _r4_o).getFileName();
    if (_r1_o != null) goto label54;
    // Value=(Unknown Source)
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)40)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 41))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    goto label37;
    label54:;
    _r2.i = ((global::java.lang.StackTraceElement) _r4_o).getLineNumber();
    _r3.i = 40;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r3.i);
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    if (_r2.i < 0) goto label76;
    _r1.i = 58;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    ((global::java.lang.StringBuilder) _r0_o).append((int) _r2.i);
    label76:;
    _r1.i = 41;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    goto label37;
//XMLVM_END_WRAPPER[java.lang.StackTraceElement: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[java.lang.StackTraceElement]
//XMLVM_END_WRAPPER[java.lang.StackTraceElement]

} // end of class: StackTraceElement

} // end of namespace: java.lang
