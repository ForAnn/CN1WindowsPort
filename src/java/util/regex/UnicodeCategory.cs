// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class UnicodeCategory: global::java.util.regex.AbstractCharClass {
public int _fcategory;

public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.UnicodeCategory: void <init>(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    ((global::java.util.regex.AbstractCharClass) _r0_o).@this();
    ((global::java.util.regex.UnicodeCategory) _r0_o)._fcategory = _r1.i;
    return;
//XMLVM_END_WRAPPER[java.util.regex.UnicodeCategory: void <init>(int)]
}

public override bool contains(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.UnicodeCategory: boolean contains(int)]
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
    _r4.i = n1;
    _r0.i = ((global::java.util.regex.UnicodeCategory) _r3_o)._falt ? 1 : 0;
    _r1.i = ((global::java.util.regex.UnicodeCategory) _r3_o)._fcategory;
    _r2.i = _r4.i & 0xffff;
    _r2.i = global::java.lang.Character.getType((char) _r2.i);
    if (_r1.i != _r2.i) goto label14;
    _r1.i = 1;
    label12:;
    _r0.i = _r0.i ^ _r1.i;
    return _r0.i!=0;
    label14:;
    _r1.i = 0;
    goto label12;
//XMLVM_END_WRAPPER[java.util.regex.UnicodeCategory: boolean contains(int)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.UnicodeCategory]
//XMLVM_END_WRAPPER[java.util.regex.UnicodeCategory]

} // end of class: UnicodeCategory

} // end of namespace: java.util.regex
