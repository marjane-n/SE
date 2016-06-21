import sqlite3
import os
DBFile = "coolGomrok.sqlite"
DB = None
def Log(msg):
    # return
    print "Sender :\t%s\nMessage : \t%s\n" % (msg[0], msg[1])

def Query(query):
    global DB
    if not os.path.isfile(DBFile):
        DB = sqlite3.connect(DBFile)
    else:
        DB = sqlite3.connect(DBFile)
    DBAns = ""
    try:
        DBAns = DB.execute(query)
    except Exception, E:
        Log(("DB", E))
    DB.commit()
    return DBAns

def ShowDB():
    global DB
    Ans = Query('''SELECT * FROM Cache;''')
    counter = 0
    print "DB Data Is :"
    for j in Ans.fetchall():
        print "Row %d\n\tHash\t%s\n\tURL\t%s\n\tAccTime\t%s\n\tFile\t%d\n\tMaxAge\t%d" % (
        counter, j[0], j[1], j[2], j[3], j[4])
        counter += 1
    return

while True:
	Q = raw_input("Enter Query : \n")
	if Q == "licenserule":
            Q = "select * from license_rule_Table_;"
	A = Query(Q)
	for i in A:
		for j in i:
			print j,
		print
