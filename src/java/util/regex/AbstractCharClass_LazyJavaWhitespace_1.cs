// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class AbstractCharClass_2LazyJavaWhitespace_21: global::java.util.regex.AbstractCharClass {
public global::java.util.regex.AbstractCharClass_2LazyJavaWhitespace _fthis_21;

public void @this(global::java.util.regex.AbstractCharClass_2LazyJavaWhitespace n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractCharClass$LazyJavaWhitespace$1: void <init>(java.util.regex.AbstractCharClass$LazyJavaWhitespace)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.regex.AbstractCharClass_2LazyJavaWhitespace_21) _r0_o)._fthis_21 = (global::java.util.regex.AbstractCharClass_2LazyJavaWhitespace) _r1_o;
    ((global::java.util.regex.AbstractCharClass) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.regex.AbstractCharClass$LazyJavaWhitespace$1: void <init>(java.util.regex.AbstractCharClass$LazyJavaWhitespace)]
}

public override bool contains(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractCharClass$LazyJavaWhitespace$1: boolean contains(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = global::java.lang.Character.isWhitespace((int) _r2.i) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.regex.AbstractCharClass$LazyJavaWhitespace$1: boolean contains(int)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractCharClass$LazyJavaWhitespace$1]
//XMLVM_END_WRAPPER[java.util.regex.AbstractCharClass$LazyJavaWhitespace$1]

} // end of class: AbstractCharClass_2LazyJavaWhitespace_21

} // end of namespace: java.util.regex
