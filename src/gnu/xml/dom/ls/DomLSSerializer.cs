// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom.ls {
public class DomLSSerializer: global::gnu.xml.transform.StreamSerializer,global::org.w3c.dom.ls.LSSerializer,global::org.w3c.dom.DOMConfiguration,global::org.w3c.dom.DOMStringList {

static DomLSSerializer() {
    @static();
}

private static global::java.util.List _fSUPPORTED_1PARAMETERS;

private global::org.w3c.dom.ls.LSSerializerFilter _ffilter;


public static void @static(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r0.i = 2;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    // Value=discard-default-content
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 1;
    // Value=xml-declaration
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)120)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r0_o = global::java.util.Arrays.asList((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o);
    global::gnu.xml.dom.ls.DomLSSerializer._fSUPPORTED_1PARAMETERS = (global::java.util.List) _r0_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: void <clinit>()]
}

public void @this(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::gnu.xml.transform.StreamSerializer) _r1_o).@this();
    _r0.i = 1;
    ((global::gnu.xml.dom.ls.DomLSSerializer) _r1_o)._fdiscardDefaultContent = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: void <init>()]
}

public virtual global::System.Object getDomConfig(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: org.w3c.dom.DOMConfiguration getDomConfig()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    return (global::org.w3c.dom.DOMConfiguration) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: org.w3c.dom.DOMConfiguration getDomConfig()]
}

public virtual global::System.Object getNewLine(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: java.lang.String getNewLine()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.ls.DomLSSerializer) _r1_o)._feol;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: java.lang.String getNewLine()]
}

public virtual void setNewLine(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: void setNewLine(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    if (_r2_o != null) goto label11;
    // Value=line.separator
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114))}));
    _r0_o = global::java.lang.System.getProperty((global::java.lang.String) _r0_o);
    label8:;
    ((global::gnu.xml.dom.ls.DomLSSerializer) _r1_o)._feol = (global::java.lang.String) _r0_o;
    return;
    label11:;
    _r0_o = _r2_o;
    goto label8;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: void setNewLine(java.lang.String)]
}

public virtual global::System.Object getFilter(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: org.w3c.dom.ls.LSSerializerFilter getFilter()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.ls.DomLSSerializer) _r1_o)._ffilter;
    return (global::org.w3c.dom.ls.LSSerializerFilter) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: org.w3c.dom.ls.LSSerializerFilter getFilter()]
}

public virtual void setFilter(global::org.w3c.dom.ls.LSSerializerFilter n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: void setFilter(org.w3c.dom.ls.LSSerializerFilter)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::gnu.xml.dom.ls.DomLSSerializer) _r0_o)._ffilter = (global::org.w3c.dom.ls.LSSerializerFilter) _r1_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: void setFilter(org.w3c.dom.ls.LSSerializerFilter)]
}

public virtual bool write(global::org.w3c.dom.Node n1, global::org.w3c.dom.ls.LSOutput n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: boolean write(org.w3c.dom.Node, org.w3c.dom.ls.LSOutput)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r5.i = 1;
    _r1_o = ((global::org.w3c.dom.ls.LSOutput) _r8_o).getByteStream();
    if (_r1_o != null) goto label41;
    try {
    _r3_o = ((global::org.w3c.dom.ls.LSOutput) _r8_o).getSystemId();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label61;
        }
        throw ex;
    } // end catch
    try {
    _r1_o = new global::java.net.URL();
    ((global::java.net.URL) _r1_o).@this((global::java.lang.String) _r3_o);
    _r2_o = ((global::java.net.URL) _r1_o).openConnection();
    _r1.i = 1;
    ((global::java.net.URLConnection) _r2_o).setDoOutput(0!=_r1.i);
    _r1.i = ((_r2_o != null) && (_r2_o is global::java.net.HttpURLConnection)) ? 1 : 0;
    if (_r1.i == 0) goto label37;
    _r0_o = _r2_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    // Value=PUT
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)80)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 84))}));
    ((global::java.net.HttpURLConnection) _r1_o).setRequestMethod((global::java.lang.String) _r4_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.net.MalformedURLException) {
            _ex = ex;
            goto label48;
        }
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label61;
        }
        throw ex;
    } // end catch
    label37:;
    try {
    _r1_o = ((global::java.net.URLConnection) _r2_o).getOutputStream();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.net.MalformedURLException) {
            _ex = ex;
            goto label48;
        }
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label61;
        }
        throw ex;
    } // end catch
    label41:;
    try {
    ((global::gnu.xml.dom.ls.DomLSSerializer) _r6_o).serialize((global::org.w3c.dom.Node) _r7_o, (global::java.io.OutputStream) _r1_o);
    ((global::java.io.OutputStream) _r1_o).flush();
    return _r5.i!=0;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label61;
        }
        throw ex;
    } // end catch
    label48:;
    try {
    _r1_o = _ex.getJavaException();
    _ex = null;
    _r1_o = new global::java.io.File();
    ((global::java.io.File) _r1_o).@this((global::java.lang.String) _r3_o);
    _r2_o = new global::java.io.FileOutputStream();
    ((global::java.io.FileOutputStream) _r2_o).@this((global::java.io.File) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label61;
        }
        throw ex;
    } // end catch
    _r1_o = _r2_o;
    goto label41;
    label61:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    _r2_o = new global::gnu.xml.dom.ls.DomLSException();
    _r3.i = 82;
    ((global::gnu.xml.dom.ls.DomLSException) _r2_o).@this((short) _r3.i, (global::java.lang.Exception) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.ls.DomLSException) _r2_o);
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: boolean write(org.w3c.dom.Node, org.w3c.dom.ls.LSOutput)]
}

public virtual bool writeToURI(global::org.w3c.dom.Node n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: boolean writeToURI(org.w3c.dom.Node, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0_o = new global::gnu.xml.dom.ls.DomLSOutput();
    ((global::gnu.xml.dom.ls.DomLSOutput) _r0_o).@this();
    ((global::org.w3c.dom.ls.LSOutput) _r0_o).setSystemId((global::java.lang.String) _r3_o);
    _r0.i = ((global::gnu.xml.dom.ls.DomLSSerializer) _r1_o).write((global::org.w3c.dom.Node) _r2_o, (global::org.w3c.dom.ls.LSOutput) _r0_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: boolean writeToURI(org.w3c.dom.Node, java.lang.String)]
}

public virtual global::System.Object writeToString(global::org.w3c.dom.Node n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: java.lang.String writeToString(org.w3c.dom.Node)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = new global::java.io.StringWriter();
    ((global::java.io.StringWriter) _r0_o).@this();
    _r1_o = new global::gnu.xml.dom.ls.DomLSOutput();
    ((global::gnu.xml.dom.ls.DomLSOutput) _r1_o).@this();
    ((global::org.w3c.dom.ls.LSOutput) _r1_o).setCharacterStream((global::java.io.Writer) _r0_o);
    ((global::gnu.xml.dom.ls.DomLSSerializer) _r2_o).write((global::org.w3c.dom.Node) _r3_o, (global::org.w3c.dom.ls.LSOutput) _r1_o);
    _r0_o = ((global::java.lang.Object) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: java.lang.String writeToString(org.w3c.dom.Node)]
}

public override void serialize(global::org.w3c.dom.Node n1, global::java.io.OutputStream n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: void serialize(org.w3c.dom.Node, java.io.OutputStream)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r0_o = ((global::gnu.xml.dom.ls.DomLSSerializer) _r2_o)._ffilter;
    if (_r0_o != null) goto label8;
    base.serialize((global::org.w3c.dom.Node) _r3_o, (global::java.io.OutputStream) _r4_o);
    label7:;
    return;
    label8:;
    _r0_o = ((global::gnu.xml.dom.ls.DomLSSerializer) _r2_o)._ffilter;
    _r0.i = ((global::org.w3c.dom.ls.LSSerializerFilter) _r0_o).getWhatToShow();
    _r1.i = -1;
    if (_r0.i == _r1.i) goto label24;
    _r1.i = ((global::org.w3c.dom.Node) _r3_o).getNodeType();
    switch (_r1.i) {
    case 1: goto label54;
    case 2: goto label38;
    case 3: goto label46;
    case 4: goto label62;
    case 5: goto label118;
    case 6: goto label110;
    case 7: goto label94;
    case 8: goto label70;
    case 9: goto label78;
    case 10: goto label86;
    case 11: goto label102;
    case 12: goto label126;
    }
    label24:;
    _r0_o = ((global::gnu.xml.dom.ls.DomLSSerializer) _r2_o)._ffilter;
    _r0.i = ((global::org.w3c.dom.ls.LSSerializerFilter) _r0_o).acceptNode((global::org.w3c.dom.Node) _r3_o);
    switch (_r0.i) {
    case 1: goto label34;
    case 2: goto label7;
    case 3: goto label134;
    }
    goto label7;
    label34:;
    base.serialize((global::org.w3c.dom.Node) _r3_o, (global::java.io.OutputStream) _r4_o);
    goto label7;
    label38:;
    _r0.i = _r0.i & 2;
    if (_r0.i != 0) goto label24;
    base.serialize((global::org.w3c.dom.Node) _r3_o, (global::java.io.OutputStream) _r4_o);
    goto label7;
    label46:;
    _r0.i = _r0.i & 4;
    if (_r0.i != 0) goto label24;
    base.serialize((global::org.w3c.dom.Node) _r3_o, (global::java.io.OutputStream) _r4_o);
    goto label7;
    label54:;
    _r0.i = _r0.i & 1;
    if (_r0.i != 0) goto label24;
    base.serialize((global::org.w3c.dom.Node) _r3_o, (global::java.io.OutputStream) _r4_o);
    goto label7;
    label62:;
    _r0.i = _r0.i & 8;
    if (_r0.i != 0) goto label24;
    base.serialize((global::org.w3c.dom.Node) _r3_o, (global::java.io.OutputStream) _r4_o);
    goto label7;
    label70:;
    _r0.i = _r0.i & 128;
    if (_r0.i != 0) goto label24;
    base.serialize((global::org.w3c.dom.Node) _r3_o, (global::java.io.OutputStream) _r4_o);
    goto label7;
    label78:;
    _r0.i = _r0.i & 256;
    if (_r0.i != 0) goto label24;
    base.serialize((global::org.w3c.dom.Node) _r3_o, (global::java.io.OutputStream) _r4_o);
    goto label7;
    label86:;
    _r0.i = _r0.i & 512;
    if (_r0.i != 0) goto label24;
    base.serialize((global::org.w3c.dom.Node) _r3_o, (global::java.io.OutputStream) _r4_o);
    goto label7;
    label94:;
    _r0.i = _r0.i & 64;
    if (_r0.i != 0) goto label24;
    base.serialize((global::org.w3c.dom.Node) _r3_o, (global::java.io.OutputStream) _r4_o);
    goto label7;
    label102:;
    _r0.i = _r0.i & 1024;
    if (_r0.i != 0) goto label24;
    base.serialize((global::org.w3c.dom.Node) _r3_o, (global::java.io.OutputStream) _r4_o);
    goto label7;
    label110:;
    _r0.i = _r0.i & 32;
    if (_r0.i != 0) goto label24;
    base.serialize((global::org.w3c.dom.Node) _r3_o, (global::java.io.OutputStream) _r4_o);
    goto label7;
    label118:;
    _r0.i = _r0.i & 16;
    if (_r0.i != 0) goto label24;
    base.serialize((global::org.w3c.dom.Node) _r3_o, (global::java.io.OutputStream) _r4_o);
    goto label7;
    label126:;
    _r0.i = _r0.i & 2048;
    if (_r0.i != 0) goto label24;
    base.serialize((global::org.w3c.dom.Node) _r3_o, (global::java.io.OutputStream) _r4_o);
    goto label7;
    label134:;
    _r0_o = ((global::org.w3c.dom.Node) _r3_o).getFirstChild();
    if (_r0_o == null) goto label7;
    ((global::gnu.xml.dom.ls.DomLSSerializer) _r2_o).serialize((global::org.w3c.dom.Node) _r0_o, (global::java.io.OutputStream) _r4_o);
    goto label7;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: void serialize(org.w3c.dom.Node, java.io.OutputStream)]
}

public virtual void setParameter(global::java.lang.String n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: void setParameter(java.lang.String, java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    // Value=discard-default-content
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r0.i == 0) goto label21;
    // Value=true
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    _r1_o = ((global::java.lang.Object) _r4_o).toString();
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    ((global::gnu.xml.dom.ls.DomLSSerializer) _r2_o)._fdiscardDefaultContent = 0!=_r0.i;
    label20:;
    return;
    label21:;
    // Value=xml-declaration
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)120)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r0.i == 0) goto label42;
    // Value=false
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101))}));
    _r1_o = ((global::java.lang.Object) _r4_o).toString();
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    ((global::gnu.xml.dom.ls.DomLSSerializer) _r2_o)._fxmlDeclaration = 0!=_r0.i;
    goto label20;
    label42:;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    _r1.i = 9;
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: void setParameter(java.lang.String, java.lang.Object)]
}

public virtual global::System.Object getParameter(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: java.lang.Object getParameter(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    // Value=true
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    // Value=false
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101))}));
    // Value=discard-default-content
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r0.i == 0) goto label24;
    _r0.i = ((global::gnu.xml.dom.ls.DomLSSerializer) _r3_o)._fdiscardDefaultContent ? 1 : 0;
    if (_r0.i == 0) goto label20;
    // Value=true
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    _r0_o = _r2_o;
    label19:;
    return (global::java.lang.Object) _r0_o;
    label20:;
    // Value=false
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101))}));
    _r0_o = _r1_o;
    goto label19;
    label24:;
    // Value=xml-declaration
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)120)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r0.i == 0) goto label44;
    _r0.i = ((global::gnu.xml.dom.ls.DomLSSerializer) _r3_o)._fxmlDeclaration ? 1 : 0;
    if (_r0.i == 0) goto label40;
    // Value=true
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    _r0_o = _r2_o;
    goto label19;
    label40:;
    // Value=false
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101))}));
    _r0_o = _r1_o;
    goto label19;
    label44:;
    _r0_o = new global::gnu.xml.dom.DomDOMException();
    _r1.i = 9;
    ((global::gnu.xml.dom.DomDOMException) _r0_o).@this((short) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::gnu.xml.dom.DomDOMException) _r0_o);
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: java.lang.Object getParameter(java.lang.String)]
}

public virtual bool canSetParameter(global::java.lang.String n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: boolean canSetParameter(java.lang.String, java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0.i = ((global::gnu.xml.dom.ls.DomLSSerializer) _r1_o).contains((global::java.lang.String) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: boolean canSetParameter(java.lang.String, java.lang.Object)]
}

public virtual global::System.Object getParameterNames(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: org.w3c.dom.DOMStringList getParameterNames()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    return (global::org.w3c.dom.DOMStringList) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: org.w3c.dom.DOMStringList getParameterNames()]
}

public virtual global::System.Object item(int n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: java.lang.String item(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = global::gnu.xml.dom.ls.DomLSSerializer._fSUPPORTED_1PARAMETERS;
    _r1_o = ((global::java.util.List) _r0_o).get((int) _r2.i);
    _r1_o = _r1_o;
    return (global::java.lang.String) _r1_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: java.lang.String item(int)]
}

public virtual int getLength(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: int getLength()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = global::gnu.xml.dom.ls.DomLSSerializer._fSUPPORTED_1PARAMETERS;
    _r0.i = ((global::java.util.List) _r0_o).size();
    return _r0.i;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: int getLength()]
}

public virtual bool contains(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: boolean contains(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = global::gnu.xml.dom.ls.DomLSSerializer._fSUPPORTED_1PARAMETERS;
    _r0.i = ((global::java.util.List) _r0_o).contains((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer: boolean contains(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSSerializer]
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSSerializer]

} // end of class: DomLSSerializer

} // end of namespace: gnu.xml.dom.ls
