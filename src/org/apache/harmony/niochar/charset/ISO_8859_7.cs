// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.niochar.charset {
public class ISO_18859_17: global::java.nio.charset.Charset {
public void @this(global::java.lang.String n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_7: void <init>(java.lang.String, java.lang.String[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::java.nio.charset.Charset) _r0_o).@this((global::java.lang.String) _r1_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o);
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_7: void <init>(java.lang.String, java.lang.String[])]
}

public override bool contains(global::java.nio.charset.Charset n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_7: boolean contains(java.nio.charset.Charset)]
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
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=IBM367
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 51)), unchecked((char) unchecked((uint) 54)), unchecked((char) unchecked((uint) 55))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label38;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=iso-8859-7
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 57)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 55))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label38;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=US-ASCII
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 73))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label38;
    _r0.i = 0;
    label37:;
    return _r0.i!=0;
    label38:;
    _r0.i = 1;
    goto label37;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_7: boolean contains(java.nio.charset.Charset)]
}

public override global::System.Object newDecoder(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_7: java.nio.charset.CharsetDecoder newDecoder()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = new global::org.apache.harmony.niochar.charset.ISO_18859_17_2Decoder();
    _r1_o = null;
    ((global::org.apache.harmony.niochar.charset.ISO_18859_17_2Decoder) _r0_o).@this((global::java.nio.charset.Charset) _r2_o, (global::org.apache.harmony.niochar.charset.ISO_18859_17_2Decoder) _r1_o);
    return (global::java.nio.charset.CharsetDecoder) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_7: java.nio.charset.CharsetDecoder newDecoder()]
}

public override global::System.Object newEncoder(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_7: java.nio.charset.CharsetEncoder newEncoder()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = new global::org.apache.harmony.niochar.charset.ISO_18859_17_2Encoder();
    _r1_o = null;
    ((global::org.apache.harmony.niochar.charset.ISO_18859_17_2Encoder) _r0_o).@this((global::java.nio.charset.Charset) _r2_o, (global::org.apache.harmony.niochar.charset.ISO_18859_17_2Encoder) _r1_o);
    return (global::java.nio.charset.CharsetEncoder) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_7: java.nio.charset.CharsetEncoder newEncoder()]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_7]
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_7]

} // end of class: ISO_18859_17

} // end of namespace: org.apache.harmony.niochar.charset
