// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.list {
public abstract class _iListModel {

} // end of abstract class: _iListModel

public interface ListModel {
 global::System.Object getItemAt(int n1);

 int getSize();

 int getSelectedIndex();

 void setSelectedIndex(int n1);

 void addDataChangedListener(global::com.codename1.ui.events.DataChangedListener n1);

 void removeDataChangedListener(global::com.codename1.ui.events.DataChangedListener n1);

 void addSelectionListener(global::com.codename1.ui.events.SelectionListener n1);

 void removeSelectionListener(global::com.codename1.ui.events.SelectionListener n1);

 void addItem(global::java.lang.Object n1);

 void removeItem(int n1);

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.ListModel]
//XMLVM_END_WRAPPER[com.codename1.ui.list.ListModel]

} // end of interface: ListModel

} // end of namespace: com.codename1.ui.list
