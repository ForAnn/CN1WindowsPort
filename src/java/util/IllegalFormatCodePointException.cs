// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class IllegalFormatCodePointException: global::java.util.IllegalFormatException,global::java.io.Serializable {
private static long _fserialVersionUID = 19080630L;

private int _fc;

public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.IllegalFormatCodePointException: void <init>(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    ((global::java.util.IllegalFormatException) _r0_o).@this();
    ((global::java.util.IllegalFormatCodePointException) _r0_o)._fc = _r1.i;
    return;
//XMLVM_END_WRAPPER[java.util.IllegalFormatCodePointException: void <init>(int)]
}

public virtual int getCodePoint(){
//XMLVM_BEGIN_WRAPPER[java.util.IllegalFormatCodePointException: int getCodePoint()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::java.util.IllegalFormatCodePointException) _r1_o)._fc;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.IllegalFormatCodePointException: int getCodePoint()]
}

public override global::System.Object getMessage(){
//XMLVM_BEGIN_WRAPPER[java.util.IllegalFormatCodePointException: java.lang.String getMessage()]
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
    ((global::java.lang.StringBuilder) _r0_o).@this();
    // Value=Code point is 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::java.util.IllegalFormatCodePointException) _r4_o)._fc;
    _r1_o = global::java.lang.Character.toChars((int) _r1.i);
    _r2.i = 0;
    label17:;
    _r3.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    if (_r2.i < _r3.i) goto label25;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
    label25:;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<char>) _r1_o)[_r2.i];
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r3.i);
    _r2.i = _r2.i + 1;
    goto label17;
//XMLVM_END_WRAPPER[java.util.IllegalFormatCodePointException: java.lang.String getMessage()]
}

//XMLVM_BEGIN_WRAPPER[java.util.IllegalFormatCodePointException]
//XMLVM_END_WRAPPER[java.util.IllegalFormatCodePointException]

} // end of class: IllegalFormatCodePointException

} // end of namespace: java.util
