// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.niochar.charset {
public class UTF_18: global::java.nio.charset.Charset {

static UTF_18() {
    @static();
}

private static global::org.xmlvm._nArrayAdapter<int> _fremainingBytes;

private static global::org.xmlvm._nArrayAdapter<int> _fremainingNumbers;

private static global::org.xmlvm._nArrayAdapter<int> _flowerEncodingLimit;

new public static void @static(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r3.i = 4;
    _r0.i = 128;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[]{-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, -1, -1, -1, -1, -1, -1, -1, -1});
    global::org.apache.harmony.niochar.charset.UTF_18._fremainingBytes = (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r3.i]);
    _r1.i = 1;
    _r2.i = 4224;
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    _r1.i = 2;
    _r2.i = 401536;
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    _r1.i = 3;
    _r2.i = 29892736;
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    global::org.apache.harmony.niochar.charset.UTF_18._fremainingNumbers = (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r3.i]);
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[]{-1, 128, 2048, 65536});
    global::org.apache.harmony.niochar.charset.UTF_18._flowerEncodingLimit = (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: void <clinit>()]
}

new public void @this(global::java.lang.String n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: void <init>(java.lang.String, java.lang.String[])]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::java.nio.charset.Charset) _r0_o).@this((global::java.lang.String) _r1_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o);
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: void <init>(java.lang.String, java.lang.String[])]
}

public override bool contains(global::java.nio.charset.Charset n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: boolean contains(java.nio.charset.Charset)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=UTF-8
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=US-ASCII
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 73))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=KOI8-R
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)75)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 82))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=windows-1250
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 48))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=windows-1251
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 49))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=windows-1252
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 50))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=windows-1253
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 51))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=windows-1254
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 52))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=windows-1257
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 55))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=ISO-8859-1
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 57)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=ISO-8859-2
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 57)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 50))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=ISO-8859-4
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 57)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 52))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=ISO-8859-5
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 57)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 53))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=ISO-8859-7
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 57)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 55))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=ISO-8859-9
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 57)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 57))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=ISO-8859-10
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 57)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 48))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=ISO-8859-13
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 57)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 51))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=ISO-8859-14
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 57)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 52))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=ISO-8859-15
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 57)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 53))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=ISO-8859-16
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 56)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 57)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 54))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=UTF-16
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 54))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=UTF-16LE
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 54)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 69))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0_o = ((global::java.nio.charset.Charset) _r3_o).name();
    // Value=UTF-16BE
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 54)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 69))}));
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label278;
    _r0.i = 0;
    label277:;
    return _r0.i!=0;
    label278:;
    _r0.i = 1;
    goto label277;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: boolean contains(java.nio.charset.Charset)]
}

public override global::System.Object newDecoder(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: java.nio.charset.CharsetDecoder newDecoder()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::org.apache.harmony.niochar.charset.UTF_18_2Decoder();
    _r1_o = null;
    ((global::org.apache.harmony.niochar.charset.UTF_18_2Decoder) _r0_o).@this((global::org.apache.harmony.niochar.charset.UTF_18) _r2_o, (global::java.nio.charset.Charset) _r2_o, (global::org.apache.harmony.niochar.charset.UTF_18_2Decoder) _r1_o);
    return (global::java.nio.charset.CharsetDecoder) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: java.nio.charset.CharsetDecoder newDecoder()]
}

public override global::System.Object newEncoder(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: java.nio.charset.CharsetEncoder newEncoder()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::org.apache.harmony.niochar.charset.UTF_18_2Encoder();
    _r1_o = null;
    ((global::org.apache.harmony.niochar.charset.UTF_18_2Encoder) _r0_o).@this((global::org.apache.harmony.niochar.charset.UTF_18) _r2_o, (global::java.nio.charset.Charset) _r2_o, (global::org.apache.harmony.niochar.charset.UTF_18_2Encoder) _r1_o);
    return (global::java.nio.charset.CharsetEncoder) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: java.nio.charset.CharsetEncoder newEncoder()]
}

public static global::System.Object access_20(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: int[] access$0()]
    global::System.Object _r0_o = null;
    _r0_o = global::org.apache.harmony.niochar.charset.UTF_18._fremainingBytes;
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: int[] access$0()]
}

public static global::System.Object access_21(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: int[] access$1()]
    global::System.Object _r0_o = null;
    _r0_o = global::org.apache.harmony.niochar.charset.UTF_18._fremainingNumbers;
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: int[] access$1()]
}

public static global::System.Object access_22(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: int[] access$2()]
    global::System.Object _r0_o = null;
    _r0_o = global::org.apache.harmony.niochar.charset.UTF_18._flowerEncodingLimit;
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.UTF_8: int[] access$2()]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.UTF_8]
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.UTF_8]

} // end of class: UTF_18

} // end of namespace: org.apache.harmony.niochar.charset
