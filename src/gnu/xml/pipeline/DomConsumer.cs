// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.pipeline {
public class DomConsumer: global::java.lang.Object,global::gnu.xml.pipeline.EventConsumer {
private global::java.lang.Class _fdomImpl;

private bool _fhidingCDATA;

private bool _fhidingComments;

private bool _fhidingWhitespace;

private bool _fhidingReferences;

private global::gnu.xml.pipeline.DomConsumer_2Handler _fhandler;

private global::org.xml.sax.ErrorHandler _ferrHandler;

private global::gnu.xml.pipeline.EventConsumer _fnext;

public void @this(global::java.lang.Class n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: void <init>(java.lang.Class)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 1;
    ((global::java.lang.Object) _r1_o).@this();
    ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fhidingCDATA = 0!=_r0.i;
    ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fhidingComments = 0!=_r0.i;
    ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fhidingWhitespace = 0!=_r0.i;
    ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fhidingReferences = 0!=_r0.i;
    ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fdomImpl = (global::java.lang.Class) _r2_o;
    _r0_o = new global::gnu.xml.pipeline.DomConsumer_2Handler();
    ((global::gnu.xml.pipeline.DomConsumer_2Handler) _r0_o).@this((global::gnu.xml.pipeline.DomConsumer) _r1_o);
    ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fhandler = (global::gnu.xml.pipeline.DomConsumer_2Handler) _r0_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: void <init>(java.lang.Class)]
}

public virtual void setHandler(global::gnu.xml.pipeline.DomConsumer_2Handler n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: void setHandler(gnu.xml.pipeline.DomConsumer$Handler)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::gnu.xml.pipeline.DomConsumer) _r0_o)._fhandler = (global::gnu.xml.pipeline.DomConsumer_2Handler) _r1_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: void setHandler(gnu.xml.pipeline.DomConsumer$Handler)]
}

private global::System.Object emptyDocument(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: org.w3c.dom.Document emptyDocument()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    try {
    _r0_o = ((global::gnu.xml.pipeline.DomConsumer) _r4_o)._fdomImpl;
    _r4_o = ((global::java.lang.Class) _r0_o).newInstance();
    _r4_o = _r4_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.IllegalAccessException) {
            _ex = ex;
            goto label9;
        }
        if (_java_exception is global::java.lang.InstantiationException) {
            _ex = ex;
            goto label35;
        }
        throw ex;
    } // end catch
    return (global::org.w3c.dom.Document) _r4_o;
    label9:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r1_o = new global::org.xml.sax.SAXException();
    _r2_o = new global::java.lang.StringBuilder();
    // Value=can't access constructor: 
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 39)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r2_o).@this((global::java.lang.String) _r3_o);
    _r0_o = ((global::java.lang.IllegalAccessException) _r0_o).getMessage();
    _r0_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r0_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    ((global::org.xml.sax.SAXException) _r1_o).@this((global::java.lang.String) _r0_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::org.xml.sax.SAXException) _r1_o);
    label35:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r1_o = new global::org.xml.sax.SAXException();
    _r2_o = new global::java.lang.StringBuilder();
    // Value=can't instantiate Document: 
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 39)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 68)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r2_o).@this((global::java.lang.String) _r3_o);
    _r0_o = ((global::java.lang.InstantiationException) _r0_o).getMessage();
    _r0_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r0_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    ((global::org.xml.sax.SAXException) _r1_o).@this((global::java.lang.String) _r0_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::org.xml.sax.SAXException) _r1_o);
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: org.w3c.dom.Document emptyDocument()]
}

public void @this(global::java.lang.Class n1, global::gnu.xml.pipeline.EventConsumer n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: void <init>(java.lang.Class, gnu.xml.pipeline.EventConsumer)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::gnu.xml.pipeline.DomConsumer) _r0_o).@this((global::java.lang.Class) _r1_o);
    ((global::gnu.xml.pipeline.DomConsumer) _r0_o)._fnext = (global::gnu.xml.pipeline.EventConsumer) _r2_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: void <init>(java.lang.Class, gnu.xml.pipeline.EventConsumer)]
}

public virtual global::System.Object getDocument(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: org.w3c.dom.Document getDocument()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fhandler;
    _r0_o = ((global::gnu.xml.pipeline.DomConsumer_2Handler) _r0_o).clearDocument();
    return (global::org.w3c.dom.Document) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: org.w3c.dom.Document getDocument()]
}

public virtual void setErrorHandler(global::org.xml.sax.ErrorHandler n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: void setErrorHandler(org.xml.sax.ErrorHandler)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::gnu.xml.pipeline.DomConsumer) _r0_o)._ferrHandler = (global::org.xml.sax.ErrorHandler) _r1_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: void setErrorHandler(org.xml.sax.ErrorHandler)]
}

public virtual bool isHidingReferences(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: boolean isHidingReferences()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fhidingReferences ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: boolean isHidingReferences()]
}

public virtual void setHidingReferences(bool n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: void setHidingReferences(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::gnu.xml.pipeline.DomConsumer) _r0_o)._fhidingReferences = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: void setHidingReferences(boolean)]
}

public virtual bool isHidingComments(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: boolean isHidingComments()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fhidingComments ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: boolean isHidingComments()]
}

public virtual void setHidingComments(bool n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: void setHidingComments(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::gnu.xml.pipeline.DomConsumer) _r0_o)._fhidingComments = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: void setHidingComments(boolean)]
}

public virtual bool isHidingWhitespace(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: boolean isHidingWhitespace()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fhidingWhitespace ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: boolean isHidingWhitespace()]
}

public virtual void setHidingWhitespace(bool n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: void setHidingWhitespace(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::gnu.xml.pipeline.DomConsumer) _r0_o)._fhidingWhitespace = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: void setHidingWhitespace(boolean)]
}

public virtual bool isHidingCDATA(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: boolean isHidingCDATA()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fhidingCDATA ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: boolean isHidingCDATA()]
}

public virtual void setHidingCDATA(bool n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: void setHidingCDATA(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::gnu.xml.pipeline.DomConsumer) _r0_o)._fhidingCDATA = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: void setHidingCDATA(boolean)]
}

public virtual global::System.Object getContentHandler(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: org.xml.sax.ContentHandler getContentHandler()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fhandler;
    return (global::org.xml.sax.ContentHandler) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: org.xml.sax.ContentHandler getContentHandler()]
}

public virtual global::System.Object getDTDHandler(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: org.xml.sax.DTDHandler getDTDHandler()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fhandler;
    return (global::org.xml.sax.DTDHandler) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: org.xml.sax.DTDHandler getDTDHandler()]
}

public virtual global::System.Object getProperty(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: java.lang.Object getProperty(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=http://xml.org/sax/properties/lexical-handler
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    if (_r0.i == 0) goto label11;
    _r0_o = ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fhandler;
    label10:;
    return (global::java.lang.Object) _r0_o;
    label11:;
    // Value=http://xml.org/sax/properties/declaration-handler
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    if (_r0.i == 0) goto label22;
    _r0_o = ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fhandler;
    goto label10;
    label22:;
    _r0_o = new global::org.xml.sax.SAXNotRecognizedException();
    ((global::org.xml.sax.SAXNotRecognizedException) _r0_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::org.xml.sax.SAXNotRecognizedException) _r0_o);
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: java.lang.Object getProperty(java.lang.String)]
}

public virtual global::System.Object getNext(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: gnu.xml.pipeline.EventConsumer getNext()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._fnext;
    return (global::gnu.xml.pipeline.EventConsumer) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: gnu.xml.pipeline.EventConsumer getNext()]
}

public virtual global::System.Object getErrorHandler(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: org.xml.sax.ErrorHandler getErrorHandler()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.pipeline.DomConsumer) _r1_o)._ferrHandler;
    return (global::org.xml.sax.ErrorHandler) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: org.xml.sax.ErrorHandler getErrorHandler()]
}

public static global::System.Object access_20(global::gnu.xml.pipeline.DomConsumer n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer: org.w3c.dom.Document access$0(gnu.xml.pipeline.DomConsumer)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r0_o = ((global::gnu.xml.pipeline.DomConsumer) _r1_o).emptyDocument();
    return (global::org.w3c.dom.Document) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer: org.w3c.dom.Document access$0(gnu.xml.pipeline.DomConsumer)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.pipeline.DomConsumer]
//XMLVM_END_WRAPPER[gnu.xml.pipeline.DomConsumer]

} // end of class: DomConsumer

} // end of namespace: gnu.xml.pipeline
