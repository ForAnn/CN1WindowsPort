// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.xml.sax.helpers {
public class XMLReaderFactory: global::java.lang.Object {

static XMLReaderFactory() {
    // Value=org.xml.sax.driver
    _fproperty = new global::java.lang.String();
    _fproperty.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
}

private static global::java.lang.String _fproperty;

private void @this(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLReaderFactory: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLReaderFactory: void <init>()]
}

public static global::System.Object createXMLReader(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLReaderFactory: org.xml.sax.XMLReader createXMLReader()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = new global::gnu.xml.stream.SAXParser();
    ((global::gnu.xml.stream.SAXParser) _r0_o).@this();
    return (global::org.xml.sax.XMLReader) _r0_o;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLReaderFactory: org.xml.sax.XMLReader createXMLReader()]
}

public static global::System.Object createXMLReader(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLReaderFactory: org.xml.sax.XMLReader createXMLReader(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r0_o = global::org.xml.sax.helpers.NewInstance.getClassLoader();
    _r0_o = global::org.xml.sax.helpers.XMLReaderFactory.loadClass((global::java.lang.ClassLoader) _r0_o, (global::java.lang.String) _r1_o);
    return (global::org.xml.sax.XMLReader) _r0_o;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLReaderFactory: org.xml.sax.XMLReader createXMLReader(java.lang.String)]
}

private static global::System.Object loadClass(global::java.lang.ClassLoader n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLReaderFactory: org.xml.sax.XMLReader loadClass(java.lang.ClassLoader, java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r8_o = n1;
    _r9_o = n2;
    // Value=SAX2 driver class 
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 88)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32))}));
    try {
    _r8_o = global::org.xml.sax.helpers.NewInstance.newInstance((global::java.lang.ClassLoader) _r8_o, (global::java.lang.String) _r9_o);
    _r8_o = _r8_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.ClassNotFoundException) {
            _ex = ex;
            goto label9;
        }
        if (_java_exception is global::java.lang.IllegalAccessException) {
            _ex = ex;
            goto label42;
        }
        if (_java_exception is global::java.lang.InstantiationException) {
            _ex = ex;
            goto label75;
        }
        if (_java_exception is global::java.lang.ClassCastException) {
            _ex = ex;
            goto label108;
        }
        throw ex;
    } // end catch
    return (global::org.xml.sax.XMLReader) _r8_o;
    label9:;
    _r4_o = _ex.getJavaException();
    _ex = null;
    _r0_o = _r4_o;
    _r4_o = new global::org.xml.sax.SAXException();
    _r5_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r5_o).@this();
    // Value=SAX2 driver class 
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 88)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32))}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r7_o);
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r9_o);
    // Value= not found
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100))}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r6_o);
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).toString();
    ((global::org.xml.sax.SAXException) _r4_o).@this((global::java.lang.String) _r5_o, (global::java.lang.Exception) _r0_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::org.xml.sax.SAXException) _r4_o);
    label42:;
    _r4_o = _ex.getJavaException();
    _ex = null;
    _r1_o = _r4_o;
    _r4_o = new global::org.xml.sax.SAXException();
    _r5_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r5_o).@this();
    // Value=SAX2 driver class 
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 88)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32))}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r7_o);
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r9_o);
    // Value= found but cannot be loaded
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r6_o);
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).toString();
    ((global::org.xml.sax.SAXException) _r4_o).@this((global::java.lang.String) _r5_o, (global::java.lang.Exception) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::org.xml.sax.SAXException) _r4_o);
    label75:;
    _r4_o = _ex.getJavaException();
    _ex = null;
    _r2_o = _r4_o;
    _r4_o = new global::org.xml.sax.SAXException();
    _r5_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r5_o).@this();
    // Value=SAX2 driver class 
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 88)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32))}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r7_o);
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r9_o);
    // Value= loaded but cannot be instantiated (no empty public constructor?)
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 40)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 63)), unchecked((char) unchecked((uint) 41))}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r6_o);
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).toString();
    ((global::org.xml.sax.SAXException) _r4_o).@this((global::java.lang.String) _r5_o, (global::java.lang.Exception) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::org.xml.sax.SAXException) _r4_o);
    label108:;
    _r4_o = _ex.getJavaException();
    _ex = null;
    _r3_o = _r4_o;
    _r4_o = new global::org.xml.sax.SAXException();
    _r5_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r5_o).@this();
    // Value=SAX2 driver class 
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 88)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32))}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r7_o);
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r9_o);
    // Value= does not implement XMLReader
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 88)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r6_o);
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).toString();
    ((global::org.xml.sax.SAXException) _r4_o).@this((global::java.lang.String) _r5_o, (global::java.lang.Exception) _r3_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::org.xml.sax.SAXException) _r4_o);
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLReaderFactory: org.xml.sax.XMLReader loadClass(java.lang.ClassLoader, java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.XMLReaderFactory]
//XMLVM_END_WRAPPER[org.xml.sax.helpers.XMLReaderFactory]

} // end of class: XMLReaderFactory

} // end of namespace: org.xml.sax.helpers
