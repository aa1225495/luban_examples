set WORKSPACE=..\..

set LUBAN_DLL=%WORKSPACE%\Tools\Luban\Luban.dll
set CONF_ROOT=%WORKSPACE%\DesignerConfigs

dotnet %LUBAN_DLL% ^
    -t all ^
    -c lua-lua ^
    -d lua  ^
    --conf %CONF_ROOT%\luban.conf ^
    -x outputCodeDir=Gen ^
    -x outputDataDir=..\GenerateDatas\lua ^
    -x pathValidator.rootDir=%WORKSPACE%\Projects\Csharp_Unity_bin ^
    -x l10n.textProviderFile=*@%WORKSPACE%\DesignerConfigs\Datas\l10n\texts.json


pause