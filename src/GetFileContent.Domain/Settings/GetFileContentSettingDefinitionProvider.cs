using Volo.Abp.Settings;

namespace GetFileContent.Settings;

public class GetFileContentSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(GetFileContentSettings.MySetting1));
    }
}
