// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.aelfred2 {
public class JAXPFactory: global::javax.xml.parsers.SAXParserFactory {
private global::java.util.Hashtable _fflags;

public void @this(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.aelfred2.JAXPFactory: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    ((global::javax.xml.parsers.SAXParserFactory) _r1_o).@this();
    _r0_o = new global::java.util.Hashtable();
    ((global::java.util.Hashtable) _r0_o).@this();
    ((global::gnu.xml.aelfred2.JAXPFactory) _r1_o)._fflags = (global::java.util.Hashtable) _r0_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.aelfred2.JAXPFactory: void <init>()]
}

public override global::System.Object newSAXParser(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.aelfred2.JAXPFactory: javax.xml.parsers.SAXParser newSAXParser()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = this;
    _r2_o = new global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser();
    ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r2_o).@this();
    _r0_o = ((global::gnu.xml.aelfred2.JAXPFactory) _r5_o)._fflags;
    _r3_o = ((global::java.util.Hashtable) _r0_o).keys();
    _r4_o = ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r2_o).getXMLReader();
    // Value=http://xml.org/sax/features/namespaces
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115))}));
    _r1.i = ((global::gnu.xml.aelfred2.JAXPFactory) _r5_o).isNamespaceAware() ? 1 : 0;
    ((global::org.xml.sax.XMLReader) _r4_o).setFeature((global::java.lang.String) _r0_o, 0!=_r1.i);
    // Value=http://xml.org/sax/features/validation
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r1.i = ((global::gnu.xml.aelfred2.JAXPFactory) _r5_o).isValidating() ? 1 : 0;
    ((global::org.xml.sax.XMLReader) _r4_o).setFeature((global::java.lang.String) _r0_o, 0!=_r1.i);
    label33:;
    _r0.i = ((global::java.util.Enumeration) _r3_o).hasMoreElements() ? 1 : 0;
    if (_r0.i != 0) goto label40;
    return (global::javax.xml.parsers.SAXParser) _r2_o;
    label40:;
    _r0_o = ((global::java.util.Enumeration) _r3_o).nextElement();
    _r0_o = _r0_o;
    _r1_o = ((global::gnu.xml.aelfred2.JAXPFactory) _r5_o)._fflags;
    _r1_o = ((global::java.util.Hashtable) _r1_o).get((global::java.lang.Object) _r0_o);
    _r1_o = _r1_o;
    _r1.i = ((global::java.lang.Boolean) _r1_o).booleanValue() ? 1 : 0;
    ((global::org.xml.sax.XMLReader) _r4_o).setFeature((global::java.lang.String) _r0_o, 0!=_r1.i);
    goto label33;
//XMLVM_END_WRAPPER[gnu.xml.aelfred2.JAXPFactory: javax.xml.parsers.SAXParser newSAXParser()]
}

public override void setFeature(global::java.lang.String n1, bool n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.aelfred2.JAXPFactory: void setFeature(java.lang.String, boolean)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5_o = n1;
    _r6.i = n2 ? 1 : 0;
    try {
    _r0_o = new global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser();
    ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r0_o).@this();
    _r0_o = ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r0_o).getXMLReader();
    ((global::org.xml.sax.XMLReader) _r0_o).setFeature((global::java.lang.String) _r5_o, 0!=_r6.i);
    _r0_o = ((global::gnu.xml.aelfred2.JAXPFactory) _r4_o)._fflags;
    _r1_o = global::java.lang.Boolean.valueOf(0!=_r6.i);
    ((global::java.util.Hashtable) _r0_o).put((global::java.lang.Object) _r5_o, (global::java.lang.Object) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::org.xml.sax.SAXNotRecognizedException) {
            _ex = ex;
            goto label22;
        }
        if (_java_exception is global::org.xml.sax.SAXNotSupportedException) {
            _ex = ex;
            goto label29;
        }
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label36;
        }
        throw ex;
    } // end catch
    return;
    label22:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = new global::org.xml.sax.SAXNotRecognizedException();
    ((global::org.xml.sax.SAXNotRecognizedException) _r0_o).@this((global::java.lang.String) _r5_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::org.xml.sax.SAXNotRecognizedException) _r0_o);
    label29:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = new global::org.xml.sax.SAXNotSupportedException();
    ((global::org.xml.sax.SAXNotSupportedException) _r0_o).@this((global::java.lang.String) _r5_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::org.xml.sax.SAXNotSupportedException) _r0_o);
    label36:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r1_o = new global::javax.xml.parsers.ParserConfigurationException();
    _r2_o = new global::java.lang.StringBuilder();
    _r3_o = ((global::java.lang.Object) _r0_o).getClass();
    _r3_o = ((global::java.lang.Class) _r3_o).getName();
    _r3_o = global::java.lang.String.valueOf((global::java.lang.Object) _r3_o);
    ((global::java.lang.StringBuilder) _r2_o).@this((global::java.lang.String) _r3_o);
    // Value=: 
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58)), unchecked((char) unchecked((uint) 32))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r0_o = ((global::java.lang.Exception) _r0_o).getMessage();
    _r0_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r0_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    ((global::javax.xml.parsers.ParserConfigurationException) _r1_o).@this((global::java.lang.String) _r0_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::javax.xml.parsers.ParserConfigurationException) _r1_o);
//XMLVM_END_WRAPPER[gnu.xml.aelfred2.JAXPFactory: void setFeature(java.lang.String, boolean)]
}

public override bool getFeature(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.aelfred2.JAXPFactory: boolean getFeature(java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5_o = n1;
    _r0_o = ((global::gnu.xml.aelfred2.JAXPFactory) _r4_o)._fflags;
    _r4_o = ((global::java.util.Hashtable) _r0_o).get((global::java.lang.Object) _r5_o);
    _r4_o = _r4_o;
    if (_r4_o == null) goto label15;
    _r0.i = ((global::java.lang.Boolean) _r4_o).booleanValue() ? 1 : 0;
    label14:;
    return _r0.i!=0;
    label15:;
    try {
    _r0_o = new global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser();
    ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r0_o).@this();
    _r0_o = ((global::gnu.xml.aelfred2.JAXPFactory_2JaxpParser) _r0_o).getXMLReader();
    _r0.i = ((global::org.xml.sax.XMLReader) _r0_o).getFeature((global::java.lang.String) _r5_o) ? 1 : 0;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::org.xml.sax.SAXNotRecognizedException) {
            _ex = ex;
            goto label29;
        }
        if (_java_exception is global::org.xml.sax.SAXNotSupportedException) {
            _ex = ex;
            goto label36;
        }
        if (_java_exception is global::org.xml.sax.SAXException) {
            _ex = ex;
            goto label43;
        }
        throw ex;
    } // end catch
    goto label14;
    label29:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = new global::org.xml.sax.SAXNotRecognizedException();
    ((global::org.xml.sax.SAXNotRecognizedException) _r0_o).@this((global::java.lang.String) _r5_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::org.xml.sax.SAXNotRecognizedException) _r0_o);
    label36:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = new global::org.xml.sax.SAXNotSupportedException();
    ((global::org.xml.sax.SAXNotSupportedException) _r0_o).@this((global::java.lang.String) _r5_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::org.xml.sax.SAXNotSupportedException) _r0_o);
    label43:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r1_o = new global::javax.xml.parsers.ParserConfigurationException();
    _r2_o = new global::java.lang.StringBuilder();
    _r3_o = ((global::java.lang.Object) _r0_o).getClass();
    _r3_o = ((global::java.lang.Class) _r3_o).getName();
    _r3_o = global::java.lang.String.valueOf((global::java.lang.Object) _r3_o);
    ((global::java.lang.StringBuilder) _r2_o).@this((global::java.lang.String) _r3_o);
    // Value=: 
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58)), unchecked((char) unchecked((uint) 32))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r0_o = ((global::org.xml.sax.SAXException) _r0_o).getMessage();
    _r0_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r0_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    ((global::javax.xml.parsers.ParserConfigurationException) _r1_o).@this((global::java.lang.String) _r0_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::javax.xml.parsers.ParserConfigurationException) _r1_o);
//XMLVM_END_WRAPPER[gnu.xml.aelfred2.JAXPFactory: boolean getFeature(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.aelfred2.JAXPFactory]
//XMLVM_END_WRAPPER[gnu.xml.aelfred2.JAXPFactory]

} // end of class: JAXPFactory

} // end of namespace: gnu.xml.aelfred2
