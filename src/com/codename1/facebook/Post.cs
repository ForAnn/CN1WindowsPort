// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.facebook {
public class Post: global::com.codename1.facebook.FBObject {
private global::java.lang.String _ftype;

private global::java.lang.String _fattribution;

private global::java.lang.String _fmessage;

private global::java.lang.String _flinkUrl;

private global::java.lang.String _flinkDescription;

private global::java.lang.String _fcommentsCount;

private global::java.lang.String _flikes;

private global::com.codename1.facebook.User _ffrom;

private global::java.util.Vector _fto;

private global::java.lang.String _fcreated_1time;

private global::java.lang.String _fpicture;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    ((global::com.codename1.facebook.FBObject) _r1_o).@this();
    _r0_o = new global::com.codename1.facebook.User();
    ((global::com.codename1.facebook.User) _r0_o).@this();
    ((global::com.codename1.facebook.Post) _r1_o)._ffrom = (global::com.codename1.facebook.User) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: void <init>()]
}

public void @this(global::java.util.Hashtable n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: void <init>(java.util.Hashtable)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::com.codename1.facebook.FBObject) _r1_o).@this((global::java.util.Hashtable) _r2_o);
    _r0_o = new global::com.codename1.facebook.User();
    ((global::com.codename1.facebook.User) _r0_o).@this();
    ((global::com.codename1.facebook.Post) _r1_o)._ffrom = (global::com.codename1.facebook.User) _r0_o;
    ((global::com.codename1.facebook.Post) _r1_o).init((global::java.util.Hashtable) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: void <init>(java.util.Hashtable)]
}

public virtual global::System.Object getFrom(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: com.codename1.facebook.User getFrom()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.facebook.Post) _r1_o)._ffrom;
    if (_r0_o != null) goto label11;
    _r0_o = new global::com.codename1.facebook.User();
    ((global::com.codename1.facebook.User) _r0_o).@this();
    ((global::com.codename1.facebook.Post) _r1_o)._ffrom = (global::com.codename1.facebook.User) _r0_o;
    label11:;
    _r0_o = ((global::com.codename1.facebook.Post) _r1_o)._ffrom;
    return (global::com.codename1.facebook.User) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: com.codename1.facebook.User getFrom()]
}

public virtual global::System.Object getTo(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: java.util.Vector getTo()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.facebook.Post) _r1_o)._fto;
    return (global::java.util.Vector) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: java.util.Vector getTo()]
}

public virtual global::System.Object getType(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: java.lang.String getType()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.facebook.Post) _r1_o)._ftype;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: java.lang.String getType()]
}

public virtual global::System.Object getAttribution(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: java.lang.String getAttribution()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.facebook.Post) _r1_o)._fattribution;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: java.lang.String getAttribution()]
}

public virtual global::System.Object getMessage(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: java.lang.String getMessage()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.facebook.Post) _r1_o)._fmessage;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: java.lang.String getMessage()]
}

public virtual global::System.Object getLinkUrl(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: java.lang.String getLinkUrl()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.facebook.Post) _r1_o)._flinkUrl;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: java.lang.String getLinkUrl()]
}

public virtual global::System.Object getCommentsCount(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: java.lang.String getCommentsCount()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.facebook.Post) _r1_o)._fcommentsCount;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: java.lang.String getCommentsCount()]
}

public virtual global::System.Object getLinkName(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: java.lang.String getLinkName()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.facebook.Post) _r1_o).getName();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: java.lang.String getLinkName()]
}

public virtual global::System.Object getLinkDescription(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: java.lang.String getLinkDescription()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.facebook.Post) _r1_o)._flinkDescription;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: java.lang.String getLinkDescription()]
}

public virtual global::System.Object getPicture(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: java.lang.String getPicture()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.facebook.Post) _r1_o)._fpicture;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: java.lang.String getPicture()]
}

public virtual global::System.Object getLikes(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: java.lang.String getLikes()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.facebook.Post) _r1_o)._flikes;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: java.lang.String getLikes()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    // Value=type = 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 61)), unchecked((char) unchecked((uint) 32))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::com.codename1.facebook.Post) _r2_o)._ftype;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    // Value= post = 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 61)), unchecked((char) unchecked((uint) 32))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::com.codename1.facebook.Post) _r2_o)._fmessage;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: java.lang.String toString()]
}

public override void copy(global::java.util.Hashtable n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: void copy(java.util.Hashtable)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    base.copy((global::java.util.Hashtable) _r1_o);
    ((global::com.codename1.facebook.Post) _r0_o).init((global::java.util.Hashtable) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: void copy(java.util.Hashtable)]
}

private void init(global::java.util.Hashtable n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post: void init(java.util.Hashtable)]
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
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r10_o = this;
    _r11_o = n1;
    // Value=count
    _r9_o = new global::java.lang.String();
    ((global::java.lang.String)_r9_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    // Value=type
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101))}));
    _r8_o = ((global::java.util.Hashtable) _r11_o).get((global::java.lang.Object) _r8_o);
    _r8_o = _r8_o;
    ((global::com.codename1.facebook.Post) _r10_o)._ftype = (global::java.lang.String) _r8_o;
    // Value=attribution
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r8_o = ((global::java.util.Hashtable) _r11_o).get((global::java.lang.Object) _r8_o);
    _r8_o = _r8_o;
    ((global::com.codename1.facebook.Post) _r10_o)._fattribution = (global::java.lang.String) _r8_o;
    // Value=message
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101))}));
    _r8_o = ((global::java.util.Hashtable) _r11_o).get((global::java.lang.Object) _r8_o);
    _r8_o = _r8_o;
    ((global::com.codename1.facebook.Post) _r10_o)._fmessage = (global::java.lang.String) _r8_o;
    // Value=link
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 107))}));
    _r8_o = ((global::java.util.Hashtable) _r11_o).get((global::java.lang.Object) _r8_o);
    _r8_o = _r8_o;
    ((global::com.codename1.facebook.Post) _r10_o)._flinkUrl = (global::java.lang.String) _r8_o;
    // Value=description
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r8_o = ((global::java.util.Hashtable) _r11_o).get((global::java.lang.Object) _r8_o);
    _r8_o = _r8_o;
    ((global::com.codename1.facebook.Post) _r10_o)._flinkDescription = (global::java.lang.String) _r8_o;
    // Value=comments
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 115))}));
    _r0_o = ((global::java.util.Hashtable) _r11_o).get((global::java.lang.Object) _r8_o);
    _r0_o = _r0_o;
    if (_r0_o == null) goto label72;
    // Value=count
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    _r8_o = ((global::java.util.Hashtable) _r0_o).get((global::java.lang.Object) _r9_o);
    _r8_o = _r8_o;
    ((global::com.codename1.facebook.Post) _r10_o)._fcommentsCount = (global::java.lang.String) _r8_o;
    label72:;
    // Value=from
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109))}));
    _r1_o = ((global::java.util.Hashtable) _r11_o).get((global::java.lang.Object) _r8_o);
    _r1_o = _r1_o;
    if (_r1_o == null) goto label87;
    _r8_o = ((global::com.codename1.facebook.Post) _r10_o)._ffrom;
    ((global::com.codename1.facebook.User) _r8_o).copy((global::java.util.Hashtable) _r1_o);
    label87:;
    // Value=to
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 111))}));
    _r5_o = ((global::java.util.Hashtable) _r11_o).get((global::java.lang.Object) _r8_o);
    _r5_o = _r5_o;
    if (_r5_o == null) goto label143;
    // Value=data
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97))}));
    _r6_o = ((global::java.util.Hashtable) _r5_o).get((global::java.lang.Object) _r8_o);
    _r6_o = _r6_o;
    if (_r6_o == null) goto label143;
    _r8_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r8_o).@this();
    ((global::com.codename1.facebook.Post) _r10_o)._fto = (global::java.util.Vector) _r8_o;
    _r2.i = 0;
    label115:;
    _r8.i = ((global::java.util.Vector) _r6_o).size();
    if (_r2.i >= _r8.i) goto label143;
    _r7_o = ((global::java.util.Vector) _r6_o).elementAt((int) _r2.i);
    _r7_o = _r7_o;
    _r4_o = new global::com.codename1.facebook.User();
    ((global::com.codename1.facebook.User) _r4_o).@this();
    ((global::com.codename1.facebook.User) _r4_o).copy((global::java.util.Hashtable) _r7_o);
    _r8_o = ((global::com.codename1.facebook.Post) _r10_o)._fto;
    ((global::java.util.Vector) _r8_o).addElement((global::java.lang.Object) _r4_o);
    _r2.i = _r2.i + 1;
    goto label115;
    label143:;
    // Value=created_time
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101))}));
    _r8_o = ((global::java.util.Hashtable) _r11_o).get((global::java.lang.Object) _r8_o);
    _r8_o = _r8_o;
    ((global::com.codename1.facebook.Post) _r10_o)._fcreated_1time = (global::java.lang.String) _r8_o;
    // Value=picture
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101))}));
    _r8_o = ((global::java.util.Hashtable) _r11_o).get((global::java.lang.Object) _r8_o);
    _r8_o = _r8_o;
    ((global::com.codename1.facebook.Post) _r10_o)._fpicture = (global::java.lang.String) _r8_o;
    // Value=likes
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115))}));
    _r3_o = ((global::java.util.Hashtable) _r11_o).get((global::java.lang.Object) _r8_o);
    if (_r3_o == null) goto label187;
    _r8.i = ((_r3_o != null) && (_r3_o is global::java.util.Hashtable)) ? 1 : 0;
    if (_r8.i == 0) goto label188;
    _r3_o = _r3_o;
    // Value=count
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    _r8_o = ((global::java.util.Hashtable) _r3_o).get((global::java.lang.Object) _r9_o);
    _r8_o = _r8_o;
    ((global::com.codename1.facebook.Post) _r10_o)._flikes = (global::java.lang.String) _r8_o;
    label187:;
    return;
    label188:;
    _r8_o = ((global::java.lang.Object) _r3_o).toString();
    ((global::com.codename1.facebook.Post) _r10_o)._flikes = (global::java.lang.String) _r8_o;
    goto label187;
//XMLVM_END_WRAPPER[com.codename1.facebook.Post: void init(java.util.Hashtable)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.Post]
//XMLVM_END_WRAPPER[com.codename1.facebook.Post]

} // end of class: Post

} // end of namespace: com.codename1.facebook
