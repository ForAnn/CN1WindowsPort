// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.lang {
public class String_2CaseInsensitiveComparator: global::java.lang.Object,global::java.util.Comparator,global::java.io.Serializable {

private void @this(){
//XMLVM_BEGIN_WRAPPER[java.lang.String$CaseInsensitiveComparator: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.lang.String$CaseInsensitiveComparator: void <init>()]
}

public virtual int compare(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[java.lang.String$CaseInsensitiveComparator: int compare(java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0.i = ((global::java.lang.String) _r2_o).compareToIgnoreCase((global::java.lang.String) _r3_o);
    return _r0.i;
//XMLVM_END_WRAPPER[java.lang.String$CaseInsensitiveComparator: int compare(java.lang.String, java.lang.String)]
}

public virtual int compare(global::java.lang.Object n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.lang.String$CaseInsensitiveComparator: int compare(java.lang.Object, java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r2_o = _r2_o;
    _r3_o = _r3_o;
    _r0.i = ((global::java.lang.String_2CaseInsensitiveComparator) _r1_o).compare((global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o);
    return _r0.i;
//XMLVM_END_WRAPPER[java.lang.String$CaseInsensitiveComparator: int compare(java.lang.Object, java.lang.Object)]
}

public void @this(global::java.lang.String_21 n1){
//XMLVM_BEGIN_WRAPPER[java.lang.String$CaseInsensitiveComparator: void <init>(java.lang.String$1)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.String_2CaseInsensitiveComparator) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.lang.String$CaseInsensitiveComparator: void <init>(java.lang.String$1)]
}

//XMLVM_BEGIN_WRAPPER[java.lang.String$CaseInsensitiveComparator]
//XMLVM_END_WRAPPER[java.lang.String$CaseInsensitiveComparator]

} // end of class: String_2CaseInsensitiveComparator

} // end of namespace: java.lang
