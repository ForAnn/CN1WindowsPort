// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class TreeMap_2Entry: global::java.util.MapEntry {
public global::java.util.TreeMap_2Entry _fparent;

public global::java.util.TreeMap_2Entry _fleft;

public global::java.util.TreeMap_2Entry _fright;

public global::java.util.TreeMap_2Node _fnode;

public int _findex;

public bool _fcolor;

public virtual void setLocation(global::java.util.TreeMap_2Node n1, int n2, global::java.lang.Object n3, global::java.lang.Object n4){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$Entry: void setLocation(java.util.TreeMap$Node, int, java.lang.Object, java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2;
    _r3_o = n3;
    _r4_o = n4;
    ((global::java.util.TreeMap_2Entry) _r0_o)._fnode = (global::java.util.TreeMap_2Node) _r1_o;
    ((global::java.util.TreeMap_2Entry) _r0_o)._findex = _r2.i;
    ((global::java.util.TreeMap_2Entry) _r0_o)._fvalue = (global::java.lang.Object) _r3_o;
    ((global::java.util.TreeMap_2Entry) _r0_o)._fkey = (global::java.lang.Object) _r4_o;
    return;
//XMLVM_END_WRAPPER[java.util.TreeMap$Entry: void setLocation(java.util.TreeMap$Node, int, java.lang.Object, java.lang.Object)]
}

new public void @this(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$Entry: void <init>(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.MapEntry) _r0_o).@this((global::java.lang.Object) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.TreeMap$Entry: void <init>(java.lang.Object)]
}

new public void @this(global::java.lang.Object n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$Entry: void <init>(java.lang.Object, java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::java.util.MapEntry) _r0_o).@this((global::java.lang.Object) _r1_o, (global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[java.util.TreeMap$Entry: void <init>(java.lang.Object, java.lang.Object)]
}

public virtual global::System.Object clone(global::java.util.TreeMap_2Entry n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$Entry: java.util.TreeMap$Entry clone(java.util.TreeMap$Entry)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = base.clone();
    ((global::java.util.TreeMap_2Entry) _r0_o)._fparent = (global::java.util.TreeMap_2Entry) _r3_o;
    _r1_o = ((global::java.util.TreeMap_2Entry) _r2_o)._fleft;
    if (_r1_o == null) goto label20;
    _r1_o = ((global::java.util.TreeMap_2Entry) _r2_o)._fleft;
    _r1_o = ((global::java.util.TreeMap_2Entry) _r1_o).clone((global::java.util.TreeMap_2Entry) _r0_o);
    ((global::java.util.TreeMap_2Entry) _r0_o)._fleft = (global::java.util.TreeMap_2Entry) _r1_o;
    label20:;
    _r1_o = ((global::java.util.TreeMap_2Entry) _r2_o)._fright;
    if (_r1_o == null) goto label32;
    _r1_o = ((global::java.util.TreeMap_2Entry) _r2_o)._fright;
    _r1_o = ((global::java.util.TreeMap_2Entry) _r1_o).clone((global::java.util.TreeMap_2Entry) _r0_o);
    ((global::java.util.TreeMap_2Entry) _r0_o)._fright = (global::java.util.TreeMap_2Entry) _r1_o;
    label32:;
    return (global::java.util.TreeMap_2Entry) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeMap$Entry: java.util.TreeMap$Entry clone(java.util.TreeMap$Entry)]
}

public override global::System.Object setValue(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$Entry: java.lang.Object setValue(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r0_o = ((global::java.util.TreeMap_2Entry) _r4_o)._fvalue;
    ((global::java.util.TreeMap_2Entry) _r4_o)._fvalue = (global::java.lang.Object) _r5_o;
    _r1_o = ((global::java.util.TreeMap_2Entry) _r4_o)._fnode;
    _r1_o = ((global::java.util.TreeMap_2Node) _r1_o)._fvalues;
    _r2.i = ((global::java.util.TreeMap_2Entry) _r4_o)._findex;
    _r3_o = ((global::java.util.TreeMap_2Entry) _r4_o)._fvalue;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r2.i] = _r3_o;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeMap$Entry: java.lang.Object setValue(java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$Entry]
//XMLVM_END_WRAPPER[java.util.TreeMap$Entry]

} // end of class: TreeMap_2Entry

} // end of namespace: java.util
