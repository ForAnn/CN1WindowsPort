// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.facebook {
public class FBObject: global::java.lang.Object {
private global::java.lang.String _fid;

private global::java.lang.String _fname;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FBObject: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.FBObject: void <init>()]
}

public void @this(global::java.util.Hashtable n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FBObject: void <init>(java.util.Hashtable)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.facebook.FBObject) _r0_o).init((global::java.util.Hashtable) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.FBObject: void <init>(java.util.Hashtable)]
}

public virtual void setId(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FBObject: void setId(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.facebook.FBObject) _r0_o)._fid = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.FBObject: void setId(java.lang.String)]
}

public virtual global::System.Object getId(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FBObject: java.lang.String getId()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.facebook.FBObject) _r1_o)._fid;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.facebook.FBObject: java.lang.String getId()]
}

public virtual global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FBObject: java.lang.String getName()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.facebook.FBObject) _r1_o)._fname;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.facebook.FBObject: java.lang.String getName()]
}

public virtual void copy(global::java.util.Hashtable n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FBObject: void copy(java.util.Hashtable)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.facebook.FBObject) _r0_o).init((global::java.util.Hashtable) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.FBObject: void copy(java.util.Hashtable)]
}

private void init(global::java.util.Hashtable n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FBObject: void init(java.util.Hashtable)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=id
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 100))}));
    _r0_o = ((global::java.util.Hashtable) _r2_o).get((global::java.lang.Object) _r0_o);
    _r0_o = _r0_o;
    ((global::com.codename1.facebook.FBObject) _r1_o)._fid = (global::java.lang.String) _r0_o;
    // Value=name
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101))}));
    _r0_o = ((global::java.util.Hashtable) _r2_o).get((global::java.lang.Object) _r0_o);
    _r0_o = _r0_o;
    ((global::com.codename1.facebook.FBObject) _r1_o)._fname = (global::java.lang.String) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.FBObject: void init(java.util.Hashtable)]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FBObject: boolean equals(java.lang.Object)]
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
    _r0_o = ((global::com.codename1.facebook.FBObject) _r2_o)._fid;
    _r3_o = _r3_o;
    _r1_o = ((global::com.codename1.facebook.FBObject) _r3_o)._fid;
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.facebook.FBObject: boolean equals(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FBObject: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.facebook.FBObject) _r1_o)._fid;
    _r0.i = ((global::java.lang.String) _r0_o).hashCode();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.facebook.FBObject: int hashCode()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FBObject]
//XMLVM_END_WRAPPER[com.codename1.facebook.FBObject]

} // end of class: FBObject

} // end of namespace: com.codename1.facebook
