import React from "react";
import { View, Text, Image, Button, StyleSheet } from "react-native";

export default function App() {
  const message = "Bem vindos(as):";
  const nome = "Izzy e Carol";

  return (
    <View style={styles.container}>
      {/* Título da tela */}
      <Text style={styles.title}>
        {message} {nome}
      </Text>

      {/* Imagem */}
      <Image
        source={{
          uri: "https://www.ufrgs.br/faunadigitalrs/wp-content/uploads/2022/03/Sapo-B-arenarum-Itapeva-1024x768.jpg",
        }}
        style={styles.image}
      />

      <Button title="Clique aqui mano" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center",
    backgroundColor: "#f5f5f5",
  },
  title: {
    fontSize: 24,
    fontWeight: "bold",
    marginBottom: 20,
    textAlign: "center",
  },
  image: {
    width: 200,
    height: 200,
    marginBottom: 20,
  },
});
