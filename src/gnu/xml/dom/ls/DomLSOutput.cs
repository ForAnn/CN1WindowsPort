// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom.ls {
public class DomLSOutput: global::java.lang.Object,global::org.w3c.dom.ls.LSOutput {
private global::java.io.OutputStream _fout;

private global::java.lang.String _fsystemId;

private global::java.lang.String _fencoding;

public void @this(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSOutput: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSOutput: void <init>()]
}

public virtual global::System.Object getCharacterStream(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSOutput: java.io.Writer getCharacterStream()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.io.OutputStreamWriter();
    _r1_o = ((global::gnu.xml.dom.ls.DomLSOutput) _r2_o)._fout;
    ((global::java.io.OutputStreamWriter) _r0_o).@this((global::java.io.OutputStream) _r1_o);
    return (global::java.io.Writer) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSOutput: java.io.Writer getCharacterStream()]
}

public virtual void setCharacterStream(global::java.io.Writer n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSOutput: void setCharacterStream(java.io.Writer)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = new global::gnu.xml.dom.ls.WriterOutputStream();
    ((global::gnu.xml.dom.ls.WriterOutputStream) _r0_o).@this((global::java.io.Writer) _r2_o);
    ((global::gnu.xml.dom.ls.DomLSOutput) _r1_o)._fout = (global::java.io.OutputStream) _r0_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSOutput: void setCharacterStream(java.io.Writer)]
}

public virtual global::System.Object getByteStream(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSOutput: java.io.OutputStream getByteStream()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.ls.DomLSOutput) _r1_o)._fout;
    return (global::java.io.OutputStream) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSOutput: java.io.OutputStream getByteStream()]
}

public virtual void setByteStream(global::java.io.OutputStream n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSOutput: void setByteStream(java.io.OutputStream)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::gnu.xml.dom.ls.DomLSOutput) _r0_o)._fout = (global::java.io.OutputStream) _r1_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSOutput: void setByteStream(java.io.OutputStream)]
}

public virtual global::System.Object getSystemId(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSOutput: java.lang.String getSystemId()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.ls.DomLSOutput) _r1_o)._fsystemId;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSOutput: java.lang.String getSystemId()]
}

public virtual void setSystemId(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSOutput: void setSystemId(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::gnu.xml.dom.ls.DomLSOutput) _r0_o)._fsystemId = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSOutput: void setSystemId(java.lang.String)]
}

public virtual global::System.Object getEncoding(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSOutput: java.lang.String getEncoding()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.ls.DomLSOutput) _r1_o)._fencoding;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSOutput: java.lang.String getEncoding()]
}

public virtual void setEncoding(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSOutput: void setEncoding(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::gnu.xml.dom.ls.DomLSOutput) _r0_o)._fencoding = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSOutput: void setEncoding(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.DomLSOutput]
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.DomLSOutput]

} // end of class: DomLSOutput

} // end of namespace: gnu.xml.dom.ls
