// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.processing {
public class XMLContent: global::java.lang.Object,global::com.codename1.processing.StructuredContent {
private global::com.codename1.xml.Element _froot;

public void @this(global::com.codename1.xml.Element n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent: void <init>(com.codename1.xml.Element)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.processing.XMLContent) _r0_o)._froot = (global::com.codename1.xml.Element) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent: void <init>(com.codename1.xml.Element)]
}

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent: void <init>(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = global::com.codename1.processing.XMLContent.wrap((global::java.lang.String) _r2_o);
    ((global::com.codename1.processing.XMLContent) _r1_o).@this((global::java.io.Reader) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent: void <init>(java.lang.String)]
}

private static global::System.Object wrap(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent: java.io.Reader wrap(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = n1;
    // Value=UTF-8
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56))}));
    try {
    _r1_o = new global::java.io.InputStreamReader();
    _r2_o = new global::java.io.ByteArrayInputStream();
    // Value=UTF-8
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56))}));
    _r3_o = ((global::java.lang.String) _r4_o).getBytes((global::java.lang.String) _r3_o);
    ((global::java.io.ByteArrayInputStream) _r2_o).@this((global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o);
    // Value=UTF-8
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56))}));
    ((global::java.io.InputStreamReader) _r1_o).@this((global::java.io.InputStream) _r2_o, (global::java.lang.String) _r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.UnsupportedEncodingException) {
            _ex = ex;
            goto label21;
        }
        throw ex;
    } // end catch
    label20:;
    return (global::java.io.Reader) _r1_o;
    label21:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    _r0_o = _r1_o;
    ((global::java.io.UnsupportedEncodingException) _r0_o).printStackTrace();
    _r1_o = null;
    goto label20;
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent: java.io.Reader wrap(java.lang.String)]
}

public void @this(global::java.io.InputStream n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent: void <init>(java.io.InputStream)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = new global::com.codename1.xml.XMLParser();
    ((global::com.codename1.xml.XMLParser) _r0_o).@this();
    _r1_o = new global::java.io.InputStreamReader();
    ((global::java.io.InputStreamReader) _r1_o).@this((global::java.io.InputStream) _r3_o);
    _r0_o = ((global::com.codename1.xml.XMLParser) _r0_o).parse((global::java.io.Reader) _r1_o);
    ((global::com.codename1.processing.XMLContent) _r2_o).@this((global::com.codename1.xml.Element) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent: void <init>(java.io.InputStream)]
}

public void @this(global::java.io.Reader n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent: void <init>(java.io.Reader)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = new global::com.codename1.xml.XMLParser();
    ((global::com.codename1.xml.XMLParser) _r0_o).@this();
    _r0_o = ((global::com.codename1.xml.XMLParser) _r0_o).parse((global::java.io.Reader) _r2_o);
    ((global::com.codename1.processing.XMLContent) _r1_o).@this((global::com.codename1.xml.Element) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent: void <init>(java.io.Reader)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    // Value=ROOT
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)82)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 84))}));
    _r1_o = ((global::com.codename1.processing.XMLContent) _r2_o)._froot;
    _r1_o = ((global::com.codename1.xml.Element) _r1_o).getTagName();
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i == 0) goto label26;
    _r0_o = ((global::com.codename1.processing.XMLContent) _r2_o)._froot;
    _r1.i = 0;
    _r0_o = ((global::com.codename1.xml.Element) _r0_o).getChildAt((int) _r1.i);
    _r0_o = ((global::com.codename1.xml.Element) _r0_o).toString();
    label25:;
    return (global::java.lang.String) _r0_o;
    label26:;
    _r0_o = ((global::com.codename1.processing.XMLContent) _r2_o).getText();
    goto label25;
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent: java.lang.String toString()]
}

private global::System.Object _1asStructuredContentArray(global::java.util.List n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent: java.util.List _asStructuredContentArray(java.util.List)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r2.i = ((_r4_o != null) && (_r4_o is global::java.util.Vector)) ? 1 : 0;
    if (_r2.i == 0) goto label34;
    _r0_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r0_o).@this();
    label9:;
    _r1_o = ((global::java.util.List) _r4_o).iterator();
    label13:;
    _r2.i = ((global::java.util.Iterator) _r1_o).hasNext() ? 1 : 0;
    if (_r2.i == 0) goto label40;
    _r2_o = new global::com.codename1.processing.XMLContent();
    _r3_o = ((global::java.util.Iterator) _r1_o).next();
    _r3_o = _r3_o;
    ((global::com.codename1.processing.XMLContent) _r2_o).@this((global::com.codename1.xml.Element) _r3_o);
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r2_o);
    goto label13;
    label34:;
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this();
    goto label9;
    label40:;
    return (global::java.util.List) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent: java.util.List _asStructuredContentArray(java.util.List)]
}

public virtual global::System.Object getChildren(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent: java.util.List getChildren(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.processing.XMLContent) _r1_o)._froot;
    _r0_o = ((global::com.codename1.xml.Element) _r0_o).getChildrenByTagName((global::java.lang.String) _r2_o);
    _r0_o = ((global::com.codename1.processing.XMLContent) _r1_o)._1asStructuredContentArray((global::java.util.List) _r0_o);
    return (global::java.util.List) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent: java.util.List getChildren(java.lang.String)]
}

public virtual global::System.Object getChild(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent: com.codename1.processing.StructuredContent getChild(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    _r0_o = new global::com.codename1.processing.XMLContent();
    _r1_o = ((global::com.codename1.processing.XMLContent) _r2_o)._froot;
    _r1_o = ((global::com.codename1.xml.Element) _r1_o).getChildAt((int) _r3.i);
    ((global::com.codename1.processing.XMLContent) _r0_o).@this((global::com.codename1.xml.Element) _r1_o);
    return (global::com.codename1.processing.StructuredContent) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent: com.codename1.processing.StructuredContent getChild(int)]
}

public virtual global::System.Object getDescendants(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent: java.util.List getDescendants(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.processing.XMLContent) _r1_o)._froot;
    _r0_o = ((global::com.codename1.xml.Element) _r0_o).getDescendantsByTagName((global::java.lang.String) _r2_o);
    _r0_o = ((global::com.codename1.processing.XMLContent) _r1_o)._1asStructuredContentArray((global::java.util.List) _r0_o);
    return (global::java.util.List) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent: java.util.List getDescendants(java.lang.String)]
}

public virtual global::System.Object getAttribute(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent: java.lang.String getAttribute(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.processing.XMLContent) _r1_o)._froot;
    _r0_o = ((global::com.codename1.xml.Element) _r0_o).getAttribute((global::java.lang.String) _r2_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent: java.lang.String getAttribute(java.lang.String)]
}

public virtual global::System.Object getAttributes(){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent: java.util.Map getAttributes()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.processing.XMLContent) _r1_o)._froot;
    _r0_o = ((global::com.codename1.xml.Element) _r0_o).getAttributes();
    return (global::java.util.Map) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent: java.util.Map getAttributes()]
}

public virtual global::System.Object getParent(){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent: com.codename1.processing.StructuredContent getParent()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1_o = ((global::com.codename1.processing.XMLContent) _r2_o)._froot;
    _r0_o = ((global::com.codename1.xml.Element) _r1_o).getParent();
    if (_r0_o != null) goto label10;
    _r1_o = null;
    label9:;
    return (global::com.codename1.processing.StructuredContent) _r1_o;
    label10:;
    _r1_o = new global::com.codename1.processing.XMLContent();
    ((global::com.codename1.processing.XMLContent) _r1_o).@this((global::com.codename1.xml.Element) _r0_o);
    goto label9;
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent: com.codename1.processing.StructuredContent getParent()]
}

public virtual global::System.Object getText(){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent: java.lang.String getText()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1.i = 0;
    _r0_o = ((global::com.codename1.processing.XMLContent) _r2_o)._froot;
    _r0.i = ((global::com.codename1.xml.Element) _r0_o).isTextElement() ? 1 : 0;
    if (_r0.i == 0) goto label16;
    _r0_o = ((global::com.codename1.processing.XMLContent) _r2_o)._froot;
    _r0_o = ((global::com.codename1.xml.Element) _r0_o).getText();
    label15:;
    return (global::java.lang.String) _r0_o;
    label16:;
    _r0_o = ((global::com.codename1.processing.XMLContent) _r2_o)._froot;
    _r0.i = ((global::com.codename1.xml.Element) _r0_o).getNumChildren();
    if (_r0.i != 0) goto label27;
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    goto label15;
    label27:;
    _r0_o = ((global::com.codename1.processing.XMLContent) _r2_o)._froot;
    _r0_o = ((global::com.codename1.xml.Element) _r0_o).getChildAt((int) _r1.i);
    _r0.i = ((global::com.codename1.xml.Element) _r0_o).isTextElement() ? 1 : 0;
    if (_r0.i == 0) goto label50;
    _r0_o = ((global::com.codename1.processing.XMLContent) _r2_o)._froot;
    _r0_o = ((global::com.codename1.xml.Element) _r0_o).getChildAt((int) _r1.i);
    _r0_o = ((global::com.codename1.xml.Element) _r0_o).getText();
    goto label15;
    label50:;
    _r0_o = ((global::com.codename1.processing.XMLContent) _r2_o)._froot;
    _r0_o = ((global::com.codename1.xml.Element) _r0_o).toString();
    goto label15;
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent: java.lang.String getText()]
}

public virtual global::System.Object getNativeRoot(){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent: java.lang.Object getNativeRoot()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.processing.XMLContent) _r1_o)._froot;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent: java.lang.Object getNativeRoot()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.processing.XMLContent]
//XMLVM_END_WRAPPER[com.codename1.processing.XMLContent]

} // end of class: XMLContent

} // end of namespace: com.codename1.processing
