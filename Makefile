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

# Spustenie programu
all: 	run

# Spustenie programu
run: 	
	$(MSBUILD) Calculator.sln $(PARAMETERS) /t:Clean,Build
	$(ROOT_DIR)\$(PROJ_NAME)\bin\Release\$(PROJ_NAME).exe

# Vycistenie projektu	
clean:
	

# Zabalenie projektu
pack:	
	

# Vypis napovedy	
help:	
	echo "make" - spustenie programu && echo "make run" - spustenie programu && echo "make all" - spustenie programu && echo "make clean" - odstranenie suborov, ktore nemaju byt odovzdane && echo "make pack" - zabali projekt na odovzdanie && echo "make help" - vypis napovedy