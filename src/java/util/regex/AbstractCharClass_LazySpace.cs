// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class AbstractCharClass_2LazySpace: global::java.util.regex.AbstractCharClass_2LazyCharClass {
public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractCharClass$LazySpace: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.util.regex.AbstractCharClass_2LazyCharClass) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.regex.AbstractCharClass$LazySpace: void <init>()]
}

public override global::System.Object computeValue(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractCharClass$LazySpace: java.util.regex.AbstractCharClass computeValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r0_o = new global::java.util.regex.CharClass();
    ((global::java.util.regex.CharClass) _r0_o).@this();
    _r1.i = 9;
    _r2.i = 13;
    _r0_o = ((global::java.util.regex.CharClass) _r0_o).add((int) _r1.i, (int) _r2.i);
    _r1.i = 32;
    _r0_o = ((global::java.util.regex.CharClass) _r0_o).add((int) _r1.i);
    return (global::java.util.regex.AbstractCharClass) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.AbstractCharClass$LazySpace: java.util.regex.AbstractCharClass computeValue()]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractCharClass$LazySpace]
//XMLVM_END_WRAPPER[java.util.regex.AbstractCharClass$LazySpace]

} // end of class: AbstractCharClass_2LazySpace

} // end of namespace: java.util.regex
