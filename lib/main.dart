import 'package:flutter/material.dart';

import 'calucltor.dart';

############

void main() {
  runApp(MaterialApp(
    debugShowCheckedModeBanner: false,
    home: Rashed(),
  ));
}

class Rashed extends StatelessWidget {
  const Rashed({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 64, 75, 141),
      appBar: AppBar(
        title: Text("Home"),
        backgroundColor: Colors.indigo,
        actions: [
          IconButton(
            icon: Icon(
              Icons.home_filled,
            ),
            onPressed: () => {},
          )
        ],
      ),
      body: Center(
        child: Column(
          children: [
            Padding(
              padding: const EdgeInsets.all(70.0),
              child: CircleAvatar(
                backgroundImage: AssetImage("asset/R.jpg"),
                radius: 90,
              ),
            ),
            Text("data"),
          ],
        ),
      ),
      drawer: Drawer(
          child: Column(
        children: [
          UserAccountsDrawerHeader(
              currentAccountPicture: CircleAvatar(
                backgroundImage: AssetImage("asset/R.jpg"),
              ),
              accountName: Text("rashed"),
              accountEmail: Text("rashed@gmail.com")),
          Divider(
            color: Colors.blue,
            height: 10,
          ),
          Padding(
            padding: const EdgeInsets.all(2.0),
            child: rashed(context, "home", Icons.home_filled, Rashed()),
          ),
          Padding(
            padding: const EdgeInsets.all(1.0),
            child:
                rashed(context, "Calculator", Icons.calculate, CalculatorApp()),
          ),
        ],
      )),
    );
  }

  ListTile rashed(BuildContext context, txt, icon, next) {
    return ListTile(
        title: Text(txt),
        tileColor: Color.fromARGB(255, 75, 154, 218),
        leading: Icon(icon),
        trailing: Icon(Icons.arrow_forward_ios),
        onTap: () =>
            Navigator.of(context).push(MaterialPageRoute(builder: (context) {
              return next;
            })));
  }
}
