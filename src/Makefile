# /*******************************************************************
# * Názov projektu: Calculator
# * 
# * Tým: LastAttic
# * Clenovia: Arbet Matúš     <xarbet00>
# *           Loncík Andrej   <xlonci00>
# *           Vagala Dominik  <xvagal00>
# *           Vinš Jakub      <xvinsj00>
# *           
# *******************************************************************/

# Dependencies
# GNU make for Windows -> http://gnuwin32.sourceforge.net/packages/make.htm
# GNU zip for Windows  -> http://gnuwin32.sourceforge.net/packages/zip.htm

# Defaultny path k Microsoft Visual Studio Builderu
MSBUILD = "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\MSBuild.exe"

# Parametre prekladu
PARAMETERS = /p:Configuration=Release

# Cesta k aktualnemu priecinku
ROOT_DIR = $(shell cd)

# Nazov programu
PROJ_NAME = Calculator

# Nazov instalatoru
PROJ_INSTALLER = CalculatorSetup

# Nazov testov
PROJ_TESTS = MathLibraryTest

# Nazov profilingu
PROJ_PROFILING = StandardDeviation

# Nazov GitHub repozitara
PROJ_GITHUB = IVS-project-2

# Nazov finalneho archivu
PROJ_FINAL = xarbet00_xlonci00_xvagal00_xvinsj00

# Spustenie programu
all:	run

# Spustenie programu
run: 	
	$(MSBUILD) Calculator.sln $(PARAMETERS) /t:Clean,Build
	$(ROOT_DIR)\$(PROJ_NAME)\bin\Release\$(PROJ_NAME).exe

# Vycistenie projektu
FILES_TO_CLEAN="$(ROOT_DIR)\$(PROJ_NAME).sln.DotSettings.user" "$(PROJ_DIR)\$(PROJ_NAME).csproj.user" "$(ROOT_DIR)\$(PROJ_TESTS)\$(PROJ_TESTS).csproj.user" "$(ROOT_DIR)\$(PROJ_PROFILING)\$(PROJ_PROFILING).csproj.user"
DIRS_TO_CLEAN="$(ROOT_DIR)\..\.vs" "$(ROOT_DIR)\packages" "$(ROOT_DIR)\$(PROJ_NAME)\bin" "$(ROOT_DIR)\$(PROJ_NAME)\obj" "$(ROOT_DIR)\$(PROJ_TESTS)\bin" "$(ROOT_DIR)\$(PROJ_TESTS)\obj" "$(ROOT_DIR)\$(PROJ_PROFILING)\bin" "$(ROOT_DIR)\$(PROJ_PROFILING)\obj" "$(ROOT_DIR)\$(PROJ_INSTALLER)\Debug" "$(ROOT_DIR)\$(PROJ_INSTALLER)\Release"	
clean:	
	for %%f in ($(FILES_TO_CLEAN)) do ( if exist %%f del %%f )
	for %%d in ($(DIRS_TO_CLEAN)) do ( if exist %%d del %%d /f /s /q 1>nul & rmdir %%d /s /q )
	if exist $(ROOT_DIR)\$(PROJ_FINAL).zip del $(ROOT_DIR)\$(PROJ_FINAL).zip

# Zabalenie projektu
pack:	
	if exist $(ROOT_DIR)\$(PROJ_FINAL)\ rmdir /s /q $(ROOT_DIR)\$(PROJ_FINAL)
	mkdir $(ROOT_DIR)\$(PROJ_FINAL)
	mkdir $(ROOT_DIR)\$(PROJ_FINAL)\install
	mkdir $(ROOT_DIR)\$(PROJ_FINAL)\doc
	mkdir $(ROOT_DIR)\$(PROJ_FINAL)\repo
	xcopy $(ROOT_DIR)\$(PROJ_INSTALLER)\$(PROJ_INSTALLER).vdproj $(ROOT_DIR)\$(PROJ_FINAL)\install
	xcopy $(ROOT_DIR)\Doxyfile $(ROOT_DIR)\$(PROJ_FINAL)\doc
	if exist $(ROOT_DIR)\$(PROJ_GITHUB)\ rmdir /s /q $(ROOT_DIR)\$(PROJ_GITHUB)
	git clone https://github.com/dvagala/IVS-project-2.git $(ROOT_DIR)\$(PROJ_FINAL)\repo
	if exist $(ROOT_DIR)\$(PROJ_FINAL).zip del $(ROOT_DIR)\$(PROJ_FINAL).zip
	powershell -nologo -noprofile -command "& { Add-Type -A 'System.IO.Compression.FileSystem'; [IO.Compression.ZipFile]::CreateFromDirectory('$(ROOT_DIR)\$(PROJ_FINAL)', '$(ROOT_DIR)\$(PROJ_FINAL).zip'); }"
	rmdir /s /q $(ROOT_DIR)\$(PROJ_FINAL)
	
# Vypis napovedy	
help:	
	echo "make" - spustenie programu && echo "make run" - spustenie programu && echo "make all" - spustenie programu && echo "make clean" - odstranenie suborov, ktore nemaju byt odovzdane && echo "make pack" - zabali projekt na odovzdanie && echo "make help" - vypis napovedy
