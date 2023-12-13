import 'package:flutter/material.dart';
import 'main.dart';

void main() {
  runApp(CalculatorApp());
}

class CalculatorApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Calculator',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: CalculatorScreen(),
    );
  }
}

class CalculatorScreen extends StatefulWidget {
  @override
  _CalculatorScreenState createState() => _CalculatorScreenState();
}

class _CalculatorScreenState extends State<CalculatorScreen> {
  String _output = '';
  double _num1 = 0;
  double _num2 = 0;
  var num1 = 0.0;
  var num2 = 0.0;
  String _operator = '';
  String operator = '   ';
  String output = '';

  void _buttonPressed(String buttonText) {
    setState(() {
      if (buttonText == 'C') {
        operator = output = _output = '';
        _num1 = _num2 = num1 = num2 = 0;
        output = '';

        _operator = '';
      } else if (buttonText == '+' ||
          buttonText == '-' ||
          buttonText == '*' ||
          buttonText == '/') {
        _num1 = double.parse(_output);
        num1 = _num1;
        _operator = buttonText;
        operator = _operator;
        _output = '';
      } else if (buttonText == '=') {
        _num2 = double.parse(_output);
        num2 = _num2;
        if (_operator == '+') {
          _output = (_num1 + _num2).toString();
        }
        if (_operator == '-') {
          _output = (_num1 - _num2).toString();
        }
        if (_operator == '*') {
          _output = (_num1 * _num2).toString();
        }

        if (_operator == '/') {
          _output = (_num1 / _num2).toString();
        }
        num1 = _num1;
        num2 = _num2;
        operator = _operator;
        output = _output;
        _num1 = 0;
        _num2 = 0;
        _operator = '';
      } else {
        _output += buttonText;
      }
    });
  }

  Widget _buildButton(String buttonText) {
    return Expanded(
      child: TextButton(
        onPressed: () => _buttonPressed(buttonText),
        child: Text(
          buttonText,
          style: TextStyle(
            fontSize: 50.0,
          ),
        ),
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Calculator'),
        leading: IconButton(
          icon: Icon(Icons.arrow_back),
          onPressed: () => {
            Navigator.of(context).push(MaterialPageRoute(builder: (context) {
              return Rashed();
            }))
          },
        ),
      ),
      body: Column(
        children: [
          Container(
            child: Row(
              children: [
                Text(num1.toString(), style: TextStyle(fontSize: 40)),
                Text(operator, style: TextStyle(fontSize: 40)),
                Text(num2.toString(), style: TextStyle(fontSize: 40)),
                Text("=", style: TextStyle(fontSize: 40)),
                Text(output, style: TextStyle(fontSize: 40)),
              ],
            ),
            color: Colors.cyan,
          ),
          Expanded(
            child: Container(
              padding: EdgeInsets.all(20.0),
              alignment: Alignment.bottomCenter,
              child: Text(
                _output,
                style: TextStyle(fontSize: 40.0, fontWeight: FontWeight.bold),
              ),
              color: Colors.cyan,
            ),
          ),
          Row(
            children: [
              _buildButton('7'),
              _buildButton('8'),
              _buildButton('9'),
              _buildButton('/'),
            ],
          ),
          Row(
            children: [
              _buildButton('4'),
              _buildButton('5'),
              _buildButton('6'),
              _buildButton('*'),
            ],
          ),
          Row(
            children: [
              _buildButton('1'),
              _buildButton('2'),
              _buildButton('3'),
              _buildButton('-'),
            ],
          ),
          Row(
            children: [
              _buildButton('0'),
              _buildButton('C'),
              _buildButton('='),
              _buildButton('+'),
            ],
          ),
        ],
      ),
    );
  }
}
