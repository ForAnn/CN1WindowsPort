// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.bouncycastle.crypto {
public abstract class _iDigest {

} // end of abstract class: _iDigest

public interface Digest {
 global::System.Object getAlgorithmName();

 int getDigestSize();

 void update(sbyte n1);

 void update(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3);

 int doFinal(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2);

 void reset();

//XMLVM_BEGIN_WRAPPER[org.bouncycastle.crypto.Digest]
//XMLVM_END_WRAPPER[org.bouncycastle.crypto.Digest]

} // end of interface: Digest

} // end of namespace: org.bouncycastle.crypto
