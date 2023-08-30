
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;

namespace cfg
{
public partial class Tables
{
    public ai.TbBlackboard TbBlackboard {get; }
    public ai.TbBehaviorTree TbBehaviorTree {get; }
    public common.TbGlobalConfig TbGlobalConfig {get; }
    /// <summary>
    /// 道具表
    /// </summary>
    public item.TbItem TbItem {get; }
    public l10n.TbL10NDemo TbL10NDemo {get; }
    public l10n.TbPatchDemo TbPatchDemo {get; }
    public tag.TbTestTag TbTestTag {get; }
    public test.TbFullTypes TbFullTypes {get; }
    public test.TbSingleton TbSingleton {get; }
    public test.TbNotIndexList TbNotIndexList {get; }
    public test.TbMultiUnionIndexList TbMultiUnionIndexList {get; }
    public test.TbMultiIndexList TbMultiIndexList {get; }
    public test.TbDataFromMisc TbDataFromMisc {get; }
    public test.TbMultiRowRecord TbMultiRowRecord {get; }
    public test.TbTestMultiColumn TbTestMultiColumn {get; }
    public test.TbMultiRowTitle TbMultiRowTitle {get; }
    public test.TbTestNull TbTestNull {get; }
    public test.TbDemoPrimitive TbDemoPrimitive {get; }
    public test.TbTestString TbTestString {get; }
    public test.TbDemoGroup TbDemoGroup {get; }
    public test.TbTestGlobal TbTestGlobal {get; }
    public test.TbTestBeRef TbTestBeRef {get; }
    public test.TbTestBeRef2 TbTestBeRef2 {get; }
    public test.TbTestRef TbTestRef {get; }
    public test.TbTestSize TbTestSize {get; }
    public test.TbTestSet TbTestSet {get; }
    public test.TbDetectCsvEncoding TbDetectCsvEncoding {get; }
    public test.TbItem2 TbItem2 {get; }
    public test.TbTestIndex TbTestIndex {get; }
    public test.TbTestMap TbTestMap {get; }
    public test.TbExcelFromJson TbExcelFromJson {get; }
    public test.TbCompositeJsonTable1 TbCompositeJsonTable1 {get; }
    public test.TbCompositeJsonTable2 TbCompositeJsonTable2 {get; }
    public test.TbCompositeJsonTable3 TbCompositeJsonTable3 {get; }
    public test.TbExcelFromJsonMultiRow TbExcelFromJsonMultiRow {get; }
    public test.TbTestScriptableObject TbTestScriptableObject {get; }
    public test.TbTestMapper TbTestMapper {get; }
    public test.TbDefineFromExcel2 TbDefineFromExcel2 {get; }

    public Tables(System.Func<string, ByteBuf> loader)
    {
        TbBlackboard = new ai.TbBlackboard(loader("ai_tbblackboard"));
        TbBehaviorTree = new ai.TbBehaviorTree(loader("ai_tbbehaviortree"));
        TbGlobalConfig = new common.TbGlobalConfig(loader("common_tbglobalconfig"));
        TbItem = new item.TbItem(loader("item_tbitem"));
        TbL10NDemo = new l10n.TbL10NDemo(loader("l10n_tbl10ndemo"));
        TbPatchDemo = new l10n.TbPatchDemo(loader("l10n_tbpatchdemo"));
        TbTestTag = new tag.TbTestTag(loader("tag_tbtesttag"));
        TbFullTypes = new test.TbFullTypes(loader("test_tbfulltypes"));
        TbSingleton = new test.TbSingleton(loader("test_tbsingleton"));
        TbNotIndexList = new test.TbNotIndexList(loader("test_tbnotindexlist"));
        TbMultiUnionIndexList = new test.TbMultiUnionIndexList(loader("test_tbmultiunionindexlist"));
        TbMultiIndexList = new test.TbMultiIndexList(loader("test_tbmultiindexlist"));
        TbDataFromMisc = new test.TbDataFromMisc(loader("test_tbdatafrommisc"));
        TbMultiRowRecord = new test.TbMultiRowRecord(loader("test_tbmultirowrecord"));
        TbTestMultiColumn = new test.TbTestMultiColumn(loader("test_tbtestmulticolumn"));
        TbMultiRowTitle = new test.TbMultiRowTitle(loader("test_tbmultirowtitle"));
        TbTestNull = new test.TbTestNull(loader("test_tbtestnull"));
        TbDemoPrimitive = new test.TbDemoPrimitive(loader("test_tbdemoprimitive"));
        TbTestString = new test.TbTestString(loader("test_tbteststring"));
        TbDemoGroup = new test.TbDemoGroup(loader("test_tbdemogroup"));
        TbTestGlobal = new test.TbTestGlobal(loader("test_tbtestglobal"));
        TbTestBeRef = new test.TbTestBeRef(loader("test_tbtestberef"));
        TbTestBeRef2 = new test.TbTestBeRef2(loader("test_tbtestberef2"));
        TbTestRef = new test.TbTestRef(loader("test_tbtestref"));
        TbTestSize = new test.TbTestSize(loader("test_tbtestsize"));
        TbTestSet = new test.TbTestSet(loader("test_tbtestset"));
        TbDetectCsvEncoding = new test.TbDetectCsvEncoding(loader("test_tbdetectcsvencoding"));
        TbItem2 = new test.TbItem2(loader("test_tbitem2"));
        TbTestIndex = new test.TbTestIndex(loader("test_tbtestindex"));
        TbTestMap = new test.TbTestMap(loader("test_tbtestmap"));
        TbExcelFromJson = new test.TbExcelFromJson(loader("test_tbexcelfromjson"));
        TbCompositeJsonTable1 = new test.TbCompositeJsonTable1(loader("test_tbcompositejsontable1"));
        TbCompositeJsonTable2 = new test.TbCompositeJsonTable2(loader("test_tbcompositejsontable2"));
        TbCompositeJsonTable3 = new test.TbCompositeJsonTable3(loader("test_tbcompositejsontable3"));
        TbExcelFromJsonMultiRow = new test.TbExcelFromJsonMultiRow(loader("test_tbexcelfromjsonmultirow"));
        TbTestScriptableObject = new test.TbTestScriptableObject(loader("test_tbtestscriptableobject"));
        TbTestMapper = new test.TbTestMapper(loader("test_tbtestmapper"));
        TbDefineFromExcel2 = new test.TbDefineFromExcel2(loader("test_tbdefinefromexcel2"));
        ResolveRef();
    }
    
    private void ResolveRef()
    {
        TbBlackboard.ResolveRef(this);
        TbBehaviorTree.ResolveRef(this);
        TbGlobalConfig.ResolveRef(this);
        TbItem.ResolveRef(this);
        TbL10NDemo.ResolveRef(this);
        TbPatchDemo.ResolveRef(this);
        TbTestTag.ResolveRef(this);
        TbFullTypes.ResolveRef(this);
        TbSingleton.ResolveRef(this);
        TbNotIndexList.ResolveRef(this);
        TbMultiUnionIndexList.ResolveRef(this);
        TbMultiIndexList.ResolveRef(this);
        TbDataFromMisc.ResolveRef(this);
        TbMultiRowRecord.ResolveRef(this);
        TbTestMultiColumn.ResolveRef(this);
        TbMultiRowTitle.ResolveRef(this);
        TbTestNull.ResolveRef(this);
        TbDemoPrimitive.ResolveRef(this);
        TbTestString.ResolveRef(this);
        TbDemoGroup.ResolveRef(this);
        TbTestGlobal.ResolveRef(this);
        TbTestBeRef.ResolveRef(this);
        TbTestBeRef2.ResolveRef(this);
        TbTestRef.ResolveRef(this);
        TbTestSize.ResolveRef(this);
        TbTestSet.ResolveRef(this);
        TbDetectCsvEncoding.ResolveRef(this);
        TbItem2.ResolveRef(this);
        TbTestIndex.ResolveRef(this);
        TbTestMap.ResolveRef(this);
        TbExcelFromJson.ResolveRef(this);
        TbCompositeJsonTable1.ResolveRef(this);
        TbCompositeJsonTable2.ResolveRef(this);
        TbCompositeJsonTable3.ResolveRef(this);
        TbExcelFromJsonMultiRow.ResolveRef(this);
        TbTestScriptableObject.ResolveRef(this);
        TbTestMapper.ResolveRef(this);
        TbDefineFromExcel2.ResolveRef(this);
    }
}

}
