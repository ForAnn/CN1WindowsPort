// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.luni.util {
public class BinarySearch: global::java.lang.Object {
new public void @this(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.BinarySearch: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.BinarySearch: void <init>()]
}

public static int binarySearch(global::java.lang.String n1, char n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.BinarySearch: int binarySearch(java.lang.String, char)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    _r6_o = n1;
    _r7.i = n2;
    _r4.i = 1;
    _r0.i = 0;
    _r1.i = ((global::java.lang.String) _r6_o).length();
    _r1.i = _r1.i - _r4.i;
    _r5.i = _r1.i;
    _r1.i = _r0.i;
    _r0.i = _r5.i;
    label10:;
    if (_r1.i <= _r0.i) goto label14;
    _r0.i = -1;
    label13:;
    return _r0.i;
    label14:;
    _r2.i = _r1.i + _r0.i;
    _r2.i = _r2.i >> (0x1f & 1);
    _r3.i = ((global::java.lang.String) _r6_o).charAt((int) _r2.i);
    if (_r7.i != _r3.i) goto label26;
    _r0.i = _r2.i;
    goto label13;
    label26:;
    if (_r7.i >= _r3.i) goto label31;
    _r0.i = _r2.i - _r4.i;
    goto label10;
    label31:;
    _r1.i = _r2.i + 1;
    goto label10;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.BinarySearch: int binarySearch(java.lang.String, char)]
}

public static int binarySearchRange(global::java.lang.String n1, char n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.BinarySearch: int binarySearchRange(java.lang.String, char)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    _r7_o = n1;
    _r8.i = n2;
    _r5.i = 1;
    _r4.i = 0;
    _r0.i = -1;
    _r1.i = ((global::java.lang.String) _r7_o).length();
    _r1.i = _r1.i - _r5.i;
    _r2.i = _r4.i;
    _r3.i = _r4.i;
    _r6.i = _r1.i;
    _r1.i = _r0.i;
    _r0.i = _r6.i;
    label13:;
    if (_r2.i <= _r0.i) goto label21;
    if (_r8.i >= _r3.i) goto label41;
    _r0.i = _r5.i;
    label18:;
    _r0.i = _r1.i - _r0.i;
    label20:;
    return _r0.i;
    label21:;
    _r1.i = _r2.i + _r0.i;
    _r1.i = _r1.i >> (0x1f & 1);
    _r3.i = ((global::java.lang.String) _r7_o).charAt((int) _r1.i);
    if (_r8.i <= _r3.i) goto label34;
    _r2.i = _r1.i + 1;
    goto label13;
    label34:;
    if (_r8.i != _r3.i) goto label38;
    _r0.i = _r1.i;
    goto label20;
    label38:;
    _r0.i = _r1.i - _r5.i;
    goto label13;
    label41:;
    _r0.i = _r4.i;
    goto label18;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.BinarySearch: int binarySearchRange(java.lang.String, char)]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.util.BinarySearch]
//XMLVM_END_WRAPPER[org.apache.harmony.luni.util.BinarySearch]

} // end of class: BinarySearch

} // end of namespace: org.apache.harmony.luni.util
